// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/rpc.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using Microservice.Grpc.Core;
using grpc = global::Grpc.Core;

namespace Microservice.Grpc.Core {
  public static partial class Rpc
  {
    static readonly string __ServiceName = "rpc.Rpc";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Microservice.Grpc.Core.RpcRequest> __Marshaller_rpc_RpcRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Microservice.Grpc.Core.RpcRequest.Parser));
    static readonly grpc::Marshaller<global::Microservice.Grpc.Core.RpcReply> __Marshaller_rpc_RpcReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Microservice.Grpc.Core.RpcReply.Parser));

    static readonly grpc::Method<global::Microservice.Grpc.Core.RpcRequest, global::Microservice.Grpc.Core.RpcReply> __Method_Execute = new grpc::Method<global::Microservice.Grpc.Core.RpcRequest, global::Microservice.Grpc.Core.RpcReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Execute",
        __Marshaller_rpc_RpcRequest,
        __Marshaller_rpc_RpcReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Microservice.Grpc.Core.RpcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Rpc</summary>
    [grpc::BindServiceMethod(typeof(Rpc), "BindService")]
    public abstract partial class RpcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Microservice.Grpc.Core.RpcReply> Execute(global::Microservice.Grpc.Core.RpcRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RpcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Execute, serviceImpl.Execute).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RpcBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Execute, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Microservice.Grpc.Core.RpcRequest, global::Microservice.Grpc.Core.RpcReply>(serviceImpl.Execute));
    }

  }

  /// <summary>Client for Rpc</summary>
    public partial class RpcClient : grpc::ClientBase<RpcClient>
    {
      
      /// <summary>Creates a new client for Rpc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RpcClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Rpc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RpcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RpcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RpcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Microservice.Grpc.Core.RpcReply Execute(global::Microservice.Grpc.Core.RpcRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Execute(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Microservice.Grpc.Core.RpcReply Execute(global::Microservice.Grpc.Core.RpcRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(RpcCore.__Method_Execute, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Microservice.Grpc.Core.RpcReply> ExecuteAsync(global::Microservice.Grpc.Core.RpcRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ExecuteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Microservice.Grpc.Core.RpcReply> ExecuteAsync(global::Microservice.Grpc.Core.RpcRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(RpcCore.__Method_Execute, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RpcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RpcClient(configuration);
      }
    }
}
#endregion
