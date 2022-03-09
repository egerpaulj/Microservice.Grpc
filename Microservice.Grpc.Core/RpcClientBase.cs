using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using LanguageExt;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Microservice.Grpc.Core
{
    public class RpcClient<T, R>
    {
        private readonly ILogger _logger;
        private readonly IGrpcMetrics _metrics;
        private readonly string _name;
        public RpcClient(ILogger logger, IGrpcMetrics metrics)
        {
            _metrics = metrics;
            _logger = logger;
            _name = this.GetType().Name;
        }

        public TryOptionAsync<R> Execute(T request, string serverAddress, Guid correlationId)
        {
            return async () =>
            {
                try
                {
                    using var channel = GrpcChannel.ForAddress(serverAddress);
                    var client = new RpcClient(channel);

                    _metrics.IncSent(_name);
                    _logger.LogInformation($"Sending response to Grpc server. Name: {_name}, CorrelationId: {correlationId}");

                    var reply = await client.ExecuteAsync(new RpcRequest
                    {
                        Correlationid = correlationId.ToString(),
                        Request = JsonConvert.SerializeObject(request),
                    });

                    if (!string.IsNullOrEmpty(reply.Errors))
                    {
                        throw new GrpcException(correlationId.ToString(), _name, reply.Errors);
                    }

                    _metrics.IncReplyReceived(_name);
                    _logger.LogInformation("Received response from Grpc server. Name: {_name}, CorrelationId: {correlationId}");
                    return JsonConvert.DeserializeObject<R>(reply.Reponse);
                }
                catch (Exception e)
                {
                    _logger.LogError(e, $"Grpc Error: {_name}, CorrelationId: {correlationId}");
                    _metrics.IncClientError(_name);
                    throw;
                }
            };
        }
    }
}