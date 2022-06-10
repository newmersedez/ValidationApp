// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto {

  /// <summary>Holder for reflection information generated from data.proto</summary>
  public static partial class DataReflection {

    #region Descriptor
    /// <summary>File descriptor for data.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpkYXRhLnByb3RvEgRkYXRhGgxjb21tb24ucHJvdG8iMAoQVmFsaWRhdGlv",
            "blJlc3VsdBIMCgRndWlkGAEgASgMEg4KBnJlY29yZBgCIAEoCSKJAQoRVmFs",
            "aWRhdGlvblJlcXVlc3QSEQoJZnVsbF9uYW1lGAEgAygJEhQKDHBob25lX251",
            "bWJlchgCIAEoCRINCgVlbWFpbBgDIAEoCRIPCgdhZGRyZXNzGAQgASgJEhcK",
            "D3Bhc3Nwb3J0X251bWJlchgFIAEoCRISCgpiaXJ0aF9kYXRlGAYgASgJImkK",
            "D1ZhbGlkYXRpb25SZXBseRIjCgZyZXN1bHQYASABKAsyEy5jb21tb24uUmVz",
            "dWx0UmVwbHkSMQoRdmFsaWRhdGlvbl9yZXN1bHQYAiADKAsyFi5kYXRhLlZh",
            "bGlkYXRpb25SZXN1bHQySAoKVmFsaWRhdGlvbhI6Cgh2YWxpZGF0ZRIXLmRh",
            "dGEuVmFsaWRhdGlvblJlcXVlc3QaFS5kYXRhLlZhbGlkYXRpb25SZXBseUII",
            "qgIFUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Proto.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.ValidationResult), global::Proto.ValidationResult.Parser, new[]{ "Guid", "Record" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.ValidationRequest), global::Proto.ValidationRequest.Parser, new[]{ "FullName", "PhoneNumber", "Email", "Address", "PassportNumber", "BirthDate" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.ValidationReply), global::Proto.ValidationReply.Parser, new[]{ "Result", "ValidationResult" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ValidationResult : pb::IMessage<ValidationResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ValidationResult> _parser = new pb::MessageParser<ValidationResult>(() => new ValidationResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ValidationResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.DataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationResult(ValidationResult other) : this() {
      guid_ = other.guid_;
      record_ = other.record_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationResult Clone() {
      return new ValidationResult(this);
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 1;
    private pb::ByteString guid_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Guid {
      get { return guid_; }
      set {
        guid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "record" field.</summary>
    public const int RecordFieldNumber = 2;
    private string record_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Record {
      get { return record_; }
      set {
        record_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ValidationResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ValidationResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      if (Record != other.Record) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid.Length != 0) hash ^= Guid.GetHashCode();
      if (Record.Length != 0) hash ^= Record.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Guid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Guid);
      }
      if (Record.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Record);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Guid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Guid);
      }
      if (Record.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Record);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Guid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Guid);
      }
      if (Record.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Record);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ValidationResult other) {
      if (other == null) {
        return;
      }
      if (other.Guid.Length != 0) {
        Guid = other.Guid;
      }
      if (other.Record.Length != 0) {
        Record = other.Record;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Guid = input.ReadBytes();
            break;
          }
          case 18: {
            Record = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Guid = input.ReadBytes();
            break;
          }
          case 18: {
            Record = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ValidationRequest : pb::IMessage<ValidationRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ValidationRequest> _parser = new pb::MessageParser<ValidationRequest>(() => new ValidationRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ValidationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.DataReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationRequest(ValidationRequest other) : this() {
      fullName_ = other.fullName_.Clone();
      phoneNumber_ = other.phoneNumber_;
      email_ = other.email_;
      address_ = other.address_;
      passportNumber_ = other.passportNumber_;
      birthDate_ = other.birthDate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationRequest Clone() {
      return new ValidationRequest(this);
    }

    /// <summary>Field number for the "full_name" field.</summary>
    public const int FullNameFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_fullName_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> fullName_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> FullName {
      get { return fullName_; }
    }

    /// <summary>Field number for the "phone_number" field.</summary>
    public const int PhoneNumberFieldNumber = 2;
    private string phoneNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PhoneNumber {
      get { return phoneNumber_; }
      set {
        phoneNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 3;
    private string email_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 4;
    private string address_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "passport_number" field.</summary>
    public const int PassportNumberFieldNumber = 5;
    private string passportNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PassportNumber {
      get { return passportNumber_; }
      set {
        passportNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "birth_date" field.</summary>
    public const int BirthDateFieldNumber = 6;
    private string birthDate_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BirthDate {
      get { return birthDate_; }
      set {
        birthDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ValidationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ValidationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!fullName_.Equals(other.fullName_)) return false;
      if (PhoneNumber != other.PhoneNumber) return false;
      if (Email != other.Email) return false;
      if (Address != other.Address) return false;
      if (PassportNumber != other.PassportNumber) return false;
      if (BirthDate != other.BirthDate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= fullName_.GetHashCode();
      if (PhoneNumber.Length != 0) hash ^= PhoneNumber.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (PassportNumber.Length != 0) hash ^= PassportNumber.GetHashCode();
      if (BirthDate.Length != 0) hash ^= BirthDate.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      fullName_.WriteTo(output, _repeated_fullName_codec);
      if (PhoneNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PhoneNumber);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Email);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Address);
      }
      if (PassportNumber.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(PassportNumber);
      }
      if (BirthDate.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(BirthDate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      fullName_.WriteTo(ref output, _repeated_fullName_codec);
      if (PhoneNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PhoneNumber);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Email);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Address);
      }
      if (PassportNumber.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(PassportNumber);
      }
      if (BirthDate.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(BirthDate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += fullName_.CalculateSize(_repeated_fullName_codec);
      if (PhoneNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PhoneNumber);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (PassportNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PassportNumber);
      }
      if (BirthDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BirthDate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ValidationRequest other) {
      if (other == null) {
        return;
      }
      fullName_.Add(other.fullName_);
      if (other.PhoneNumber.Length != 0) {
        PhoneNumber = other.PhoneNumber;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      if (other.PassportNumber.Length != 0) {
        PassportNumber = other.PassportNumber;
      }
      if (other.BirthDate.Length != 0) {
        BirthDate = other.BirthDate;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            fullName_.AddEntriesFrom(input, _repeated_fullName_codec);
            break;
          }
          case 18: {
            PhoneNumber = input.ReadString();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 34: {
            Address = input.ReadString();
            break;
          }
          case 42: {
            PassportNumber = input.ReadString();
            break;
          }
          case 50: {
            BirthDate = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            fullName_.AddEntriesFrom(ref input, _repeated_fullName_codec);
            break;
          }
          case 18: {
            PhoneNumber = input.ReadString();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 34: {
            Address = input.ReadString();
            break;
          }
          case 42: {
            PassportNumber = input.ReadString();
            break;
          }
          case 50: {
            BirthDate = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  ///TODO one reply per record?
  /// </summary>
  public sealed partial class ValidationReply : pb::IMessage<ValidationReply>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ValidationReply> _parser = new pb::MessageParser<ValidationReply>(() => new ValidationReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ValidationReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.DataReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationReply(ValidationReply other) : this() {
      result_ = other.result_ != null ? other.result_.Clone() : null;
      validationResult_ = other.validationResult_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationReply Clone() {
      return new ValidationReply(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::Proto.ResultReply result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Proto.ResultReply Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "validation_result" field.</summary>
    public const int ValidationResultFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Proto.ValidationResult> _repeated_validationResult_codec
        = pb::FieldCodec.ForMessage(18, global::Proto.ValidationResult.Parser);
    private readonly pbc::RepeatedField<global::Proto.ValidationResult> validationResult_ = new pbc::RepeatedField<global::Proto.ValidationResult>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Proto.ValidationResult> ValidationResult {
      get { return validationResult_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ValidationReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ValidationReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Result, other.Result)) return false;
      if(!validationResult_.Equals(other.validationResult_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (result_ != null) hash ^= Result.GetHashCode();
      hash ^= validationResult_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (result_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Result);
      }
      validationResult_.WriteTo(output, _repeated_validationResult_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (result_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Result);
      }
      validationResult_.WriteTo(ref output, _repeated_validationResult_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (result_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Result);
      }
      size += validationResult_.CalculateSize(_repeated_validationResult_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ValidationReply other) {
      if (other == null) {
        return;
      }
      if (other.result_ != null) {
        if (result_ == null) {
          Result = new global::Proto.ResultReply();
        }
        Result.MergeFrom(other.Result);
      }
      validationResult_.Add(other.validationResult_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (result_ == null) {
              Result = new global::Proto.ResultReply();
            }
            input.ReadMessage(Result);
            break;
          }
          case 18: {
            validationResult_.AddEntriesFrom(input, _repeated_validationResult_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (result_ == null) {
              Result = new global::Proto.ResultReply();
            }
            input.ReadMessage(Result);
            break;
          }
          case 18: {
            validationResult_.AddEntriesFrom(ref input, _repeated_validationResult_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code