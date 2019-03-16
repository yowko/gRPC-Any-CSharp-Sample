// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: message.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace gRPC.Message {

  /// <summary>Holder for reflection information generated from message.proto</summary>
  public static partial class MessageReflection {

    #region Descriptor
    /// <summary>File descriptor for message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1tZXNzYWdlLnByb3RvEgxnUlBDLk1lc3NhZ2UaGWdvb2dsZS9wcm90b2J1",
            "Zi9hbnkucHJvdG8iKwoOQWRkVXNlclJlcXVlc3QSDAoETmFtZRgBIAEoCRIL",
            "CgNBZ2UYAiABKAUiEQoPR2V0VXNlcnNSZXF1ZXN0IiEKEURlbGV0ZVVzZXJS",
            "ZXF1ZXN0EgwKBE5hbWUYASABKAkicAoIUmVzcG9uc2USEQoJSXNTdWNjZXNz",
            "GAEgASgIEicKCVJlc3VsdE1zZxgCIAEoCzIULmdvb2dsZS5wcm90b2J1Zi5B",
            "bnkSKAoKUmVzdWx0TXNncxgDIAMoCzIULmdvb2dsZS5wcm90b2J1Zi5Bbnky",
            "2AEKC2dSUENTZXJ2aWNlEj8KB0FkZFVzZXISHC5nUlBDLk1lc3NhZ2UuQWRk",
            "VXNlclJlcXVlc3QaFi5nUlBDLk1lc3NhZ2UuUmVzcG9uc2USQQoIR2V0VXNl",
            "cnMSHS5nUlBDLk1lc3NhZ2UuR2V0VXNlcnNSZXF1ZXN0GhYuZ1JQQy5NZXNz",
            "YWdlLlJlc3BvbnNlEkUKCkRlbGV0ZVVzZXISHy5nUlBDLk1lc3NhZ2UuRGVs",
            "ZXRlVXNlclJlcXVlc3QaFi5nUlBDLk1lc3NhZ2UuUmVzcG9uc2VCD6oCDGdS",
            "UEMuTWVzc2FnZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC.Message.AddUserRequest), global::gRPC.Message.AddUserRequest.Parser, new[]{ "Name", "Age" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC.Message.GetUsersRequest), global::gRPC.Message.GetUsersRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC.Message.DeleteUserRequest), global::gRPC.Message.DeleteUserRequest.Parser, new[]{ "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC.Message.Response), global::gRPC.Message.Response.Parser, new[]{ "IsSuccess", "ResultMsg", "ResultMsgs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AddUserRequest : pb::IMessage<AddUserRequest> {
    private static readonly pb::MessageParser<AddUserRequest> _parser = new pb::MessageParser<AddUserRequest>(() => new AddUserRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddUserRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC.Message.MessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddUserRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddUserRequest(AddUserRequest other) : this() {
      name_ = other.name_;
      age_ = other.age_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddUserRequest Clone() {
      return new AddUserRequest(this);
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Age" field.</summary>
    public const int AgeFieldNumber = 2;
    private int age_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Age {
      get { return age_; }
      set {
        age_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddUserRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddUserRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Age != other.Age) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Age != 0) hash ^= Age.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Age != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Age);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Age != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Age);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddUserRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Age != 0) {
        Age = other.Age;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Age = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetUsersRequest : pb::IMessage<GetUsersRequest> {
    private static readonly pb::MessageParser<GetUsersRequest> _parser = new pb::MessageParser<GetUsersRequest>(() => new GetUsersRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetUsersRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC.Message.MessageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUsersRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUsersRequest(GetUsersRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUsersRequest Clone() {
      return new GetUsersRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetUsersRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetUsersRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetUsersRequest other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  public sealed partial class DeleteUserRequest : pb::IMessage<DeleteUserRequest> {
    private static readonly pb::MessageParser<DeleteUserRequest> _parser = new pb::MessageParser<DeleteUserRequest>(() => new DeleteUserRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeleteUserRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC.Message.MessageReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteUserRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteUserRequest(DeleteUserRequest other) : this() {
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteUserRequest Clone() {
      return new DeleteUserRequest(this);
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeleteUserRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeleteUserRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeleteUserRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Response : pb::IMessage<Response> {
    private static readonly pb::MessageParser<Response> _parser = new pb::MessageParser<Response>(() => new Response());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Response> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC.Message.MessageReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response(Response other) : this() {
      isSuccess_ = other.isSuccess_;
      resultMsg_ = other.resultMsg_ != null ? other.resultMsg_.Clone() : null;
      resultMsgs_ = other.resultMsgs_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response Clone() {
      return new Response(this);
    }

    /// <summary>Field number for the "IsSuccess" field.</summary>
    public const int IsSuccessFieldNumber = 1;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "ResultMsg" field.</summary>
    public const int ResultMsgFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Any resultMsg_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any ResultMsg {
      get { return resultMsg_; }
      set {
        resultMsg_ = value;
      }
    }

    /// <summary>Field number for the "ResultMsgs" field.</summary>
    public const int ResultMsgsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Any> _repeated_resultMsgs_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Protobuf.WellKnownTypes.Any.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> resultMsgs_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> ResultMsgs {
      get { return resultMsgs_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Response);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Response other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsSuccess != other.IsSuccess) return false;
      if (!object.Equals(ResultMsg, other.ResultMsg)) return false;
      if(!resultMsgs_.Equals(other.resultMsgs_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (resultMsg_ != null) hash ^= ResultMsg.GetHashCode();
      hash ^= resultMsgs_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IsSuccess != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsSuccess);
      }
      if (resultMsg_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ResultMsg);
      }
      resultMsgs_.WriteTo(output, _repeated_resultMsgs_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (resultMsg_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResultMsg);
      }
      size += resultMsgs_.CalculateSize(_repeated_resultMsgs_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Response other) {
      if (other == null) {
        return;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.resultMsg_ != null) {
        if (resultMsg_ == null) {
          resultMsg_ = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        ResultMsg.MergeFrom(other.ResultMsg);
      }
      resultMsgs_.Add(other.resultMsgs_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 18: {
            if (resultMsg_ == null) {
              resultMsg_ = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(resultMsg_);
            break;
          }
          case 26: {
            resultMsgs_.AddEntriesFrom(input, _repeated_resultMsgs_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
