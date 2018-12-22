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
          "Cg1tZXNzYWdlLnByb3RvIrUDCgdNZXNzYWdlEhYKDmF1dGhlbnRpY2F0aW9u",
          "GAEgASgJEhsKBHR5cGUYAiABKA4yDS5NZXNzYWdlLlR5cGUSJgoNaG9zdF9h",
          "Y2NvdW50cxgDIAEoCzINLkhvc3RBY2NvdW50c0gAEg4KBHVzZXIYBCABKAlI",
          "ABIsChBhY2NvdW50X3NldHRpbmdzGAUgASgLMhAuQWNjb3VudFNldHRpbmdz",
          "SAASHgoJc2V0X2hvdXJzGAYgASgLMgkuU2V0SG91cnNIABIPCgVlcnJvchgH",
          "IAEoDUgAItIBCgRUeXBlEhgKFExJU1RfQUNDT1VOVF9SRVFVRVNUEAASGQoV",
          "TElTVF9BQ0NPVU5UX1JFU1BPTlNFEAESHAoYQUNDT1VOVF9TRVRUSU5HU19S",
          "RVFVRVNUEAMSHQoZQUNDT1VOVF9TRVRUSU5HU19SRVNQT05TRRAEEhIKDkVO",
          "QUJMRV9SRVFVRVNUEAUSEwoPRElTQUJMRV9SRVFVRVNUEAYSGwoXU0VUX0xP",
          "R09OX0hPVVJTX1JFUVVFU1QQBxISCg5FUlJPUl9SRVNQT05TRRAIQgkKB3Bh",
          "eWxvYWQiOAoMSG9zdEFjY291bnRzEgwKBGhvc3QYASABKAkSGgoIYWNjb3Vu",
          "dHMYAiADKAsyCC5BY2NvdW50IhcKB0FjY291bnQSDAoEbmFtZRgBIAEoCSJG",
          "Cg9BY2NvdW50U2V0dGluZ3MSDAoEbmFtZRgBIAEoCRIQCghkaXNhYmxlZBgC",
          "IAEoCBITCgtsb2dvbl9ob3VycxgDIAEoDCItCghTZXRIb3VycxIMCgRuYW1l",
          "GAEgASgJEhMKC2xvZ29uX2hvdXJzGAIgASgMYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Message), global::Message.Parser, new[]{ "Authentication", "Type", "HostAccounts", "User", "AccountSettings", "SetHours", "Error" }, new[]{ "Payload" }, new[]{ typeof(global::Message.Types.Type) }, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::HostAccounts), global::HostAccounts.Parser, new[]{ "Host", "Accounts" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Account), global::Account.Parser, new[]{ "Name" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::AccountSettings), global::AccountSettings.Parser, new[]{ "Name", "Disabled", "LogonHours" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SetHours), global::SetHours.Parser, new[]{ "Name", "LogonHours" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Message : pb::IMessage<Message> {
  private static readonly pb::MessageParser<Message> _parser = new pb::MessageParser<Message>(() => new Message());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Message> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MessageReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Message() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Message(Message other) : this() {
    authentication_ = other.authentication_;
    type_ = other.type_;
    switch (other.PayloadCase) {
      case PayloadOneofCase.HostAccounts:
        HostAccounts = other.HostAccounts.Clone();
        break;
      case PayloadOneofCase.User:
        User = other.User;
        break;
      case PayloadOneofCase.AccountSettings:
        AccountSettings = other.AccountSettings.Clone();
        break;
      case PayloadOneofCase.SetHours:
        SetHours = other.SetHours.Clone();
        break;
      case PayloadOneofCase.Error:
        Error = other.Error;
        break;
    }

    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Message Clone() {
    return new Message(this);
  }

  /// <summary>Field number for the "authentication" field.</summary>
  public const int AuthenticationFieldNumber = 1;
  private string authentication_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Authentication {
    get { return authentication_; }
    set {
      authentication_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "type" field.</summary>
  public const int TypeFieldNumber = 2;
  private global::Message.Types.Type type_ = 0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Message.Types.Type Type {
    get { return type_; }
    set {
      type_ = value;
    }
  }

  /// <summary>Field number for the "host_accounts" field.</summary>
  public const int HostAccountsFieldNumber = 3;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::HostAccounts HostAccounts {
    get { return payloadCase_ == PayloadOneofCase.HostAccounts ? (global::HostAccounts) payload_ : null; }
    set {
      payload_ = value;
      payloadCase_ = value == null ? PayloadOneofCase.None : PayloadOneofCase.HostAccounts;
    }
  }

  /// <summary>Field number for the "user" field.</summary>
  public const int UserFieldNumber = 4;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string User {
    get { return payloadCase_ == PayloadOneofCase.User ? (string) payload_ : ""; }
    set {
      payload_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      payloadCase_ = PayloadOneofCase.User;
    }
  }

  /// <summary>Field number for the "account_settings" field.</summary>
  public const int AccountSettingsFieldNumber = 5;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::AccountSettings AccountSettings {
    get { return payloadCase_ == PayloadOneofCase.AccountSettings ? (global::AccountSettings) payload_ : null; }
    set {
      payload_ = value;
      payloadCase_ = value == null ? PayloadOneofCase.None : PayloadOneofCase.AccountSettings;
    }
  }

  /// <summary>Field number for the "set_hours" field.</summary>
  public const int SetHoursFieldNumber = 6;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::SetHours SetHours {
    get { return payloadCase_ == PayloadOneofCase.SetHours ? (global::SetHours) payload_ : null; }
    set {
      payload_ = value;
      payloadCase_ = value == null ? PayloadOneofCase.None : PayloadOneofCase.SetHours;
    }
  }

  /// <summary>Field number for the "error" field.</summary>
  public const int ErrorFieldNumber = 7;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public uint Error {
    get { return payloadCase_ == PayloadOneofCase.Error ? (uint) payload_ : 0; }
    set {
      payload_ = value;
      payloadCase_ = PayloadOneofCase.Error;
    }
  }

  private object payload_;
  /// <summary>Enum of possible cases for the "payload" oneof.</summary>
  public enum PayloadOneofCase {
    None = 0,
    HostAccounts = 3,
    User = 4,
    AccountSettings = 5,
    SetHours = 6,
    Error = 7,
  }
  private PayloadOneofCase payloadCase_ = PayloadOneofCase.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PayloadOneofCase PayloadCase {
    get { return payloadCase_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void ClearPayload() {
    payloadCase_ = PayloadOneofCase.None;
    payload_ = null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Message);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Message other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Authentication != other.Authentication) return false;
    if (Type != other.Type) return false;
    if (!object.Equals(HostAccounts, other.HostAccounts)) return false;
    if (User != other.User) return false;
    if (!object.Equals(AccountSettings, other.AccountSettings)) return false;
    if (!object.Equals(SetHours, other.SetHours)) return false;
    if (Error != other.Error) return false;
    if (PayloadCase != other.PayloadCase) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Authentication.Length != 0) hash ^= Authentication.GetHashCode();
    if (Type != 0) hash ^= Type.GetHashCode();
    if (payloadCase_ == PayloadOneofCase.HostAccounts) hash ^= HostAccounts.GetHashCode();
    if (payloadCase_ == PayloadOneofCase.User) hash ^= User.GetHashCode();
    if (payloadCase_ == PayloadOneofCase.AccountSettings) hash ^= AccountSettings.GetHashCode();
    if (payloadCase_ == PayloadOneofCase.SetHours) hash ^= SetHours.GetHashCode();
    if (payloadCase_ == PayloadOneofCase.Error) hash ^= Error.GetHashCode();
    hash ^= (int) payloadCase_;
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
    if (Authentication.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Authentication);
    }
    if (Type != 0) {
      output.WriteRawTag(16);
      output.WriteEnum((int) Type);
    }
    if (payloadCase_ == PayloadOneofCase.HostAccounts) {
      output.WriteRawTag(26);
      output.WriteMessage(HostAccounts);
    }
    if (payloadCase_ == PayloadOneofCase.User) {
      output.WriteRawTag(34);
      output.WriteString(User);
    }
    if (payloadCase_ == PayloadOneofCase.AccountSettings) {
      output.WriteRawTag(42);
      output.WriteMessage(AccountSettings);
    }
    if (payloadCase_ == PayloadOneofCase.SetHours) {
      output.WriteRawTag(50);
      output.WriteMessage(SetHours);
    }
    if (payloadCase_ == PayloadOneofCase.Error) {
      output.WriteRawTag(56);
      output.WriteUInt32(Error);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Authentication.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Authentication);
    }
    if (Type != 0) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
    }
    if (payloadCase_ == PayloadOneofCase.HostAccounts) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(HostAccounts);
    }
    if (payloadCase_ == PayloadOneofCase.User) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(User);
    }
    if (payloadCase_ == PayloadOneofCase.AccountSettings) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccountSettings);
    }
    if (payloadCase_ == PayloadOneofCase.SetHours) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SetHours);
    }
    if (payloadCase_ == PayloadOneofCase.Error) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Error);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Message other) {
    if (other == null) {
      return;
    }
    if (other.Authentication.Length != 0) {
      Authentication = other.Authentication;
    }
    if (other.Type != 0) {
      Type = other.Type;
    }
    switch (other.PayloadCase) {
      case PayloadOneofCase.HostAccounts:
        if (HostAccounts == null) {
          HostAccounts = new global::HostAccounts();
        }
        HostAccounts.MergeFrom(other.HostAccounts);
        break;
      case PayloadOneofCase.User:
        User = other.User;
        break;
      case PayloadOneofCase.AccountSettings:
        if (AccountSettings == null) {
          AccountSettings = new global::AccountSettings();
        }
        AccountSettings.MergeFrom(other.AccountSettings);
        break;
      case PayloadOneofCase.SetHours:
        if (SetHours == null) {
          SetHours = new global::SetHours();
        }
        SetHours.MergeFrom(other.SetHours);
        break;
      case PayloadOneofCase.Error:
        Error = other.Error;
        break;
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
          Authentication = input.ReadString();
          break;
        }
        case 16: {
          type_ = (global::Message.Types.Type) input.ReadEnum();
          break;
        }
        case 26: {
          global::HostAccounts subBuilder = new global::HostAccounts();
          if (payloadCase_ == PayloadOneofCase.HostAccounts) {
            subBuilder.MergeFrom(HostAccounts);
          }
          input.ReadMessage(subBuilder);
          HostAccounts = subBuilder;
          break;
        }
        case 34: {
          User = input.ReadString();
          break;
        }
        case 42: {
          global::AccountSettings subBuilder = new global::AccountSettings();
          if (payloadCase_ == PayloadOneofCase.AccountSettings) {
            subBuilder.MergeFrom(AccountSettings);
          }
          input.ReadMessage(subBuilder);
          AccountSettings = subBuilder;
          break;
        }
        case 50: {
          global::SetHours subBuilder = new global::SetHours();
          if (payloadCase_ == PayloadOneofCase.SetHours) {
            subBuilder.MergeFrom(SetHours);
          }
          input.ReadMessage(subBuilder);
          SetHours = subBuilder;
          break;
        }
        case 56: {
          Error = input.ReadUInt32();
          break;
        }
      }
    }
  }

  #region Nested types
  /// <summary>Container for nested types declared in the Message message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static partial class Types {
    public enum Type {
      [pbr::OriginalName("LIST_ACCOUNT_REQUEST")] ListAccountRequest = 0,
      [pbr::OriginalName("LIST_ACCOUNT_RESPONSE")] ListAccountResponse = 1,
      [pbr::OriginalName("ACCOUNT_SETTINGS_REQUEST")] AccountSettingsRequest = 3,
      [pbr::OriginalName("ACCOUNT_SETTINGS_RESPONSE")] AccountSettingsResponse = 4,
      [pbr::OriginalName("ENABLE_REQUEST")] EnableRequest = 5,
      [pbr::OriginalName("DISABLE_REQUEST")] DisableRequest = 6,
      [pbr::OriginalName("SET_LOGON_HOURS_REQUEST")] SetLogonHoursRequest = 7,
      [pbr::OriginalName("ERROR_RESPONSE")] ErrorResponse = 8,
    }

  }
  #endregion

}

public sealed partial class HostAccounts : pb::IMessage<HostAccounts> {
  private static readonly pb::MessageParser<HostAccounts> _parser = new pb::MessageParser<HostAccounts>(() => new HostAccounts());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<HostAccounts> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MessageReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public HostAccounts() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public HostAccounts(HostAccounts other) : this() {
    host_ = other.host_;
    accounts_ = other.accounts_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public HostAccounts Clone() {
    return new HostAccounts(this);
  }

  /// <summary>Field number for the "host" field.</summary>
  public const int HostFieldNumber = 1;
  private string host_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Host {
    get { return host_; }
    set {
      host_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "accounts" field.</summary>
  public const int AccountsFieldNumber = 2;
  private static readonly pb::FieldCodec<global::Account> _repeated_accounts_codec
      = pb::FieldCodec.ForMessage(18, global::Account.Parser);
  private readonly pbc::RepeatedField<global::Account> accounts_ = new pbc::RepeatedField<global::Account>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Account> Accounts {
    get { return accounts_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as HostAccounts);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(HostAccounts other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Host != other.Host) return false;
    if(!accounts_.Equals(other.accounts_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Host.Length != 0) hash ^= Host.GetHashCode();
    hash ^= accounts_.GetHashCode();
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
    if (Host.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Host);
    }
    accounts_.WriteTo(output, _repeated_accounts_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Host.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Host);
    }
    size += accounts_.CalculateSize(_repeated_accounts_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(HostAccounts other) {
    if (other == null) {
      return;
    }
    if (other.Host.Length != 0) {
      Host = other.Host;
    }
    accounts_.Add(other.accounts_);
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
          Host = input.ReadString();
          break;
        }
        case 18: {
          accounts_.AddEntriesFrom(input, _repeated_accounts_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class Account : pb::IMessage<Account> {
  private static readonly pb::MessageParser<Account> _parser = new pb::MessageParser<Account>(() => new Account());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Account> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MessageReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Account() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Account(Account other) : this() {
    name_ = other.name_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Account Clone() {
    return new Account(this);
  }

  /// <summary>Field number for the "name" field.</summary>
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
    return Equals(other as Account);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Account other) {
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
  public void MergeFrom(Account other) {
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

public sealed partial class AccountSettings : pb::IMessage<AccountSettings> {
  private static readonly pb::MessageParser<AccountSettings> _parser = new pb::MessageParser<AccountSettings>(() => new AccountSettings());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AccountSettings> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MessageReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AccountSettings() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AccountSettings(AccountSettings other) : this() {
    name_ = other.name_;
    disabled_ = other.disabled_;
    logonHours_ = other.logonHours_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AccountSettings Clone() {
    return new AccountSettings(this);
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 1;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "disabled" field.</summary>
  public const int DisabledFieldNumber = 2;
  private bool disabled_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Disabled {
    get { return disabled_; }
    set {
      disabled_ = value;
    }
  }

  /// <summary>Field number for the "logon_hours" field.</summary>
  public const int LogonHoursFieldNumber = 3;
  private pb::ByteString logonHours_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString LogonHours {
    get { return logonHours_; }
    set {
      logonHours_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AccountSettings);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AccountSettings other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if (Disabled != other.Disabled) return false;
    if (LogonHours != other.LogonHours) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    if (Disabled != false) hash ^= Disabled.GetHashCode();
    if (LogonHours.Length != 0) hash ^= LogonHours.GetHashCode();
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
    if (Disabled != false) {
      output.WriteRawTag(16);
      output.WriteBool(Disabled);
    }
    if (LogonHours.Length != 0) {
      output.WriteRawTag(26);
      output.WriteBytes(LogonHours);
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
    if (Disabled != false) {
      size += 1 + 1;
    }
    if (LogonHours.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(LogonHours);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(AccountSettings other) {
    if (other == null) {
      return;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    if (other.Disabled != false) {
      Disabled = other.Disabled;
    }
    if (other.LogonHours.Length != 0) {
      LogonHours = other.LogonHours;
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
          Disabled = input.ReadBool();
          break;
        }
        case 26: {
          LogonHours = input.ReadBytes();
          break;
        }
      }
    }
  }

}

public sealed partial class SetHours : pb::IMessage<SetHours> {
  private static readonly pb::MessageParser<SetHours> _parser = new pb::MessageParser<SetHours>(() => new SetHours());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SetHours> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MessageReflection.Descriptor.MessageTypes[4]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SetHours() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SetHours(SetHours other) : this() {
    name_ = other.name_;
    logonHours_ = other.logonHours_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SetHours Clone() {
    return new SetHours(this);
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 1;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "logon_hours" field.</summary>
  public const int LogonHoursFieldNumber = 2;
  private pb::ByteString logonHours_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString LogonHours {
    get { return logonHours_; }
    set {
      logonHours_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SetHours);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SetHours other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if (LogonHours != other.LogonHours) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    if (LogonHours.Length != 0) hash ^= LogonHours.GetHashCode();
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
    if (LogonHours.Length != 0) {
      output.WriteRawTag(18);
      output.WriteBytes(LogonHours);
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
    if (LogonHours.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(LogonHours);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SetHours other) {
    if (other == null) {
      return;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    if (other.LogonHours.Length != 0) {
      LogonHours = other.LogonHours;
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
        case 18: {
          LogonHours = input.ReadBytes();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
