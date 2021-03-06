// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: address.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ValidationServers.Address {
  public static partial class ValidationAddress
  {
    static readonly string __ServiceName = "address.ValidationAddress";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ValidationServers.Address.AuthenticationRequest> __Marshaller_address_AuthenticationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ValidationServers.Address.AuthenticationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ValidationServers.Address.AuthenticationReply> __Marshaller_address_AuthenticationReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ValidationServers.Address.AuthenticationReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ValidationServers.Address.ValidationAddressRequest> __Marshaller_address_ValidationAddressRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ValidationServers.Address.ValidationAddressRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ValidationServers.Address.ValidationAddressReply> __Marshaller_address_ValidationAddressReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ValidationServers.Address.ValidationAddressReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ValidationServers.Address.DataRequest> __Marshaller_address_DataRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ValidationServers.Address.DataRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ValidationServers.Address.DataReply> __Marshaller_address_DataReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ValidationServers.Address.DataReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ValidationServers.Address.AuthenticationRequest, global::ValidationServers.Address.AuthenticationReply> __Method_Authenticate = new grpc::Method<global::ValidationServers.Address.AuthenticationRequest, global::ValidationServers.Address.AuthenticationReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Authenticate",
        __Marshaller_address_AuthenticationRequest,
        __Marshaller_address_AuthenticationReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ValidationServers.Address.ValidationAddressRequest, global::ValidationServers.Address.ValidationAddressReply> __Method_ValidateAddress = new grpc::Method<global::ValidationServers.Address.ValidationAddressRequest, global::ValidationServers.Address.ValidationAddressReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ValidateAddress",
        __Marshaller_address_ValidationAddressRequest,
        __Marshaller_address_ValidationAddressReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ValidationServers.Address.DataRequest, global::ValidationServers.Address.DataReply> __Method_GetServerData = new grpc::Method<global::ValidationServers.Address.DataRequest, global::ValidationServers.Address.DataReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetServerData",
        __Marshaller_address_DataRequest,
        __Marshaller_address_DataReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ValidationServers.Address.AddressReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ValidationAddress</summary>
    public partial class ValidationAddressClient : grpc::ClientBase<ValidationAddressClient>
    {
      /// <summary>Creates a new client for ValidationAddress</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ValidationAddressClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ValidationAddress that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ValidationAddressClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ValidationAddressClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ValidationAddressClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ValidationServers.Address.AuthenticationReply Authenticate(global::ValidationServers.Address.AuthenticationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Authenticate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ValidationServers.Address.AuthenticationReply Authenticate(global::ValidationServers.Address.AuthenticationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Authenticate, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ValidationServers.Address.AuthenticationReply> AuthenticateAsync(global::ValidationServers.Address.AuthenticationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AuthenticateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ValidationServers.Address.AuthenticationReply> AuthenticateAsync(global::ValidationServers.Address.AuthenticationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Authenticate, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ValidationServers.Address.ValidationAddressReply ValidateAddress(global::ValidationServers.Address.ValidationAddressRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ValidateAddress(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ValidationServers.Address.ValidationAddressReply ValidateAddress(global::ValidationServers.Address.ValidationAddressRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ValidateAddress, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ValidationServers.Address.ValidationAddressReply> ValidateAddressAsync(global::ValidationServers.Address.ValidationAddressRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ValidateAddressAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ValidationServers.Address.ValidationAddressReply> ValidateAddressAsync(global::ValidationServers.Address.ValidationAddressRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ValidateAddress, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ValidationServers.Address.DataReply GetServerData(global::ValidationServers.Address.DataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetServerData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ValidationServers.Address.DataReply GetServerData(global::ValidationServers.Address.DataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetServerData, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ValidationServers.Address.DataReply> GetServerDataAsync(global::ValidationServers.Address.DataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetServerDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ValidationServers.Address.DataReply> GetServerDataAsync(global::ValidationServers.Address.DataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetServerData, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ValidationAddressClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ValidationAddressClient(configuration);
      }
    }

  }
}
#endregion
