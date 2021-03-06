// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: fullname.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ValidationServers.Fullname {
  public static partial class ValidationFullname
  {
    static readonly string __ServiceName = "fullname.ValidationFullname";

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
    static readonly grpc::Marshaller<global::ValidationServers.Fullname.AuthenticationRequest> __Marshaller_fullname_AuthenticationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ValidationServers.Fullname.AuthenticationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ValidationServers.Fullname.AuthenticationReply> __Marshaller_fullname_AuthenticationReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ValidationServers.Fullname.AuthenticationReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ValidationServers.Fullname.ValidationFullnameRequest> __Marshaller_fullname_ValidationFullnameRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ValidationServers.Fullname.ValidationFullnameRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ValidationServers.Fullname.ValidationFullnameReply> __Marshaller_fullname_ValidationFullnameReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ValidationServers.Fullname.ValidationFullnameReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ValidationServers.Fullname.DataRequest> __Marshaller_fullname_DataRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ValidationServers.Fullname.DataRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ValidationServers.Fullname.DataReply> __Marshaller_fullname_DataReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ValidationServers.Fullname.DataReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ValidationServers.Fullname.AuthenticationRequest, global::ValidationServers.Fullname.AuthenticationReply> __Method_Authenticate = new grpc::Method<global::ValidationServers.Fullname.AuthenticationRequest, global::ValidationServers.Fullname.AuthenticationReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Authenticate",
        __Marshaller_fullname_AuthenticationRequest,
        __Marshaller_fullname_AuthenticationReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ValidationServers.Fullname.ValidationFullnameRequest, global::ValidationServers.Fullname.ValidationFullnameReply> __Method_ValidateFullname = new grpc::Method<global::ValidationServers.Fullname.ValidationFullnameRequest, global::ValidationServers.Fullname.ValidationFullnameReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ValidateFullname",
        __Marshaller_fullname_ValidationFullnameRequest,
        __Marshaller_fullname_ValidationFullnameReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ValidationServers.Fullname.DataRequest, global::ValidationServers.Fullname.DataReply> __Method_GetServerData = new grpc::Method<global::ValidationServers.Fullname.DataRequest, global::ValidationServers.Fullname.DataReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetServerData",
        __Marshaller_fullname_DataRequest,
        __Marshaller_fullname_DataReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ValidationServers.Fullname.FullnameReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ValidationFullname</summary>
    public partial class ValidationFullnameClient : grpc::ClientBase<ValidationFullnameClient>
    {
      /// <summary>Creates a new client for ValidationFullname</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ValidationFullnameClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ValidationFullname that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ValidationFullnameClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ValidationFullnameClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ValidationFullnameClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ValidationServers.Fullname.AuthenticationReply Authenticate(global::ValidationServers.Fullname.AuthenticationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Authenticate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ValidationServers.Fullname.AuthenticationReply Authenticate(global::ValidationServers.Fullname.AuthenticationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Authenticate, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ValidationServers.Fullname.AuthenticationReply> AuthenticateAsync(global::ValidationServers.Fullname.AuthenticationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AuthenticateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ValidationServers.Fullname.AuthenticationReply> AuthenticateAsync(global::ValidationServers.Fullname.AuthenticationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Authenticate, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ValidationServers.Fullname.ValidationFullnameReply ValidateFullname(global::ValidationServers.Fullname.ValidationFullnameRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ValidateFullname(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ValidationServers.Fullname.ValidationFullnameReply ValidateFullname(global::ValidationServers.Fullname.ValidationFullnameRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ValidateFullname, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ValidationServers.Fullname.ValidationFullnameReply> ValidateFullnameAsync(global::ValidationServers.Fullname.ValidationFullnameRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ValidateFullnameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ValidationServers.Fullname.ValidationFullnameReply> ValidateFullnameAsync(global::ValidationServers.Fullname.ValidationFullnameRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ValidateFullname, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ValidationServers.Fullname.DataReply GetServerData(global::ValidationServers.Fullname.DataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetServerData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ValidationServers.Fullname.DataReply GetServerData(global::ValidationServers.Fullname.DataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetServerData, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ValidationServers.Fullname.DataReply> GetServerDataAsync(global::ValidationServers.Fullname.DataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetServerDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ValidationServers.Fullname.DataReply> GetServerDataAsync(global::ValidationServers.Fullname.DataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetServerData, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ValidationFullnameClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ValidationFullnameClient(configuration);
      }
    }

  }
}
#endregion
