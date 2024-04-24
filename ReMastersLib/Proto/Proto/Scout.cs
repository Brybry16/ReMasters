// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/Scout.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/Scout.proto</summary>
  public static partial class ScoutReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/Scout.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScoutReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQcm90by9TY291dC5wcm90bxIMUmVNYXN0ZXJzTGliIrcBCgVTY291dBIQ",
            "CghzY291dF9pZBgBIAEoCRIYChBiYW5uZXJfaWRfc3RyaW5nGAIgASgJEhwK",
            "FHBpY2t1cF9uYW1lX292ZXJyaWRlGAMgASgJEgwKBHR5cGUYBCABKA0SEwoL",
            "c2NoZWR1bGVfaWQYBSABKAkSCgoCdTUYBiABKAQSCgoCdTYYByABKA0SCgoC",
            "dTcYCCABKA0SEQoJYmFubmVyX2lkGAkgASgNEgoKAnU5GAogASgJIjIKClNj",
            "b3V0VGFibGUSJAoHZW50cmllcxgBIAMoCzITLlJlTWFzdGVyc0xpYi5TY291",
            "dGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.Scout), global::ReMastersLib.Scout.Parser, new[]{ "ScoutId", "BannerIdString", "PickupNameOverride", "Type", "ScheduleId", "U5", "U6", "U7", "BannerId", "U9" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.ScoutTable), global::ReMastersLib.ScoutTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Scout : pb::IMessage<Scout>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Scout> _parser = new pb::MessageParser<Scout>(() => new Scout());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Scout> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.ScoutReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Scout() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Scout(Scout other) : this() {
      scoutId_ = other.scoutId_;
      bannerIdString_ = other.bannerIdString_;
      pickupNameOverride_ = other.pickupNameOverride_;
      type_ = other.type_;
      scheduleId_ = other.scheduleId_;
      u5_ = other.u5_;
      u6_ = other.u6_;
      u7_ = other.u7_;
      bannerId_ = other.bannerId_;
      u9_ = other.u9_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Scout Clone() {
      return new Scout(this);
    }

    /// <summary>Field number for the "scout_id" field.</summary>
    public const int ScoutIdFieldNumber = 1;
    private string scoutId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ScoutId {
      get { return scoutId_; }
      set {
        scoutId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "banner_id_string" field.</summary>
    public const int BannerIdStringFieldNumber = 2;
    private string bannerIdString_ = "";
    /// <summary>
    /// Banner.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BannerIdString {
      get { return bannerIdString_; }
      set {
        bannerIdString_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pickup_name_override" field.</summary>
    public const int PickupNameOverrideFieldNumber = 3;
    private string pickupNameOverride_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PickupNameOverride {
      get { return pickupNameOverride_; }
      set {
        pickupNameOverride_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private uint type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "schedule_id" field.</summary>
    public const int ScheduleIdFieldNumber = 5;
    private string scheduleId_ = "";
    /// <summary>
    ///
    ///0 = Tutorial Scout
    ///1 = Spotlight Scout
    ///2 = 5* Guaranteed Scout
    ///5 = Poké Fair Scout
    ///6 = Featured Type Scout
    ///7 = Seasonal Scout
    ///8 = 5* Select Special Scout
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ScheduleId {
      get { return scheduleId_; }
      set {
        scheduleId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "u5" field.</summary>
    public const int U5FieldNumber = 6;
    private ulong u5_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong U5 {
      get { return u5_; }
      set {
        u5_ = value;
      }
    }

    /// <summary>Field number for the "u6" field.</summary>
    public const int U6FieldNumber = 7;
    private uint u6_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint U6 {
      get { return u6_; }
      set {
        u6_ = value;
      }
    }

    /// <summary>Field number for the "u7" field.</summary>
    public const int U7FieldNumber = 8;
    private uint u7_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint U7 {
      get { return u7_; }
      set {
        u7_ = value;
      }
    }

    /// <summary>Field number for the "banner_id" field.</summary>
    public const int BannerIdFieldNumber = 9;
    private uint bannerId_;
    /// <summary>
    /// Banner.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BannerId {
      get { return bannerId_; }
      set {
        bannerId_ = value;
      }
    }

    /// <summary>Field number for the "u9" field.</summary>
    public const int U9FieldNumber = 10;
    private string u9_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string U9 {
      get { return u9_; }
      set {
        u9_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Scout);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Scout other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ScoutId != other.ScoutId) return false;
      if (BannerIdString != other.BannerIdString) return false;
      if (PickupNameOverride != other.PickupNameOverride) return false;
      if (Type != other.Type) return false;
      if (ScheduleId != other.ScheduleId) return false;
      if (U5 != other.U5) return false;
      if (U6 != other.U6) return false;
      if (U7 != other.U7) return false;
      if (BannerId != other.BannerId) return false;
      if (U9 != other.U9) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ScoutId.Length != 0) hash ^= ScoutId.GetHashCode();
      if (BannerIdString.Length != 0) hash ^= BannerIdString.GetHashCode();
      if (PickupNameOverride.Length != 0) hash ^= PickupNameOverride.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (ScheduleId.Length != 0) hash ^= ScheduleId.GetHashCode();
      if (U5 != 0UL) hash ^= U5.GetHashCode();
      if (U6 != 0) hash ^= U6.GetHashCode();
      if (U7 != 0) hash ^= U7.GetHashCode();
      if (BannerId != 0) hash ^= BannerId.GetHashCode();
      if (U9.Length != 0) hash ^= U9.GetHashCode();
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
      if (ScoutId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ScoutId);
      }
      if (BannerIdString.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BannerIdString);
      }
      if (PickupNameOverride.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PickupNameOverride);
      }
      if (Type != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Type);
      }
      if (ScheduleId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ScheduleId);
      }
      if (U5 != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(U5);
      }
      if (U6 != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(U6);
      }
      if (U7 != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(U7);
      }
      if (BannerId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BannerId);
      }
      if (U9.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(U9);
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
      if (ScoutId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ScoutId);
      }
      if (BannerIdString.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BannerIdString);
      }
      if (PickupNameOverride.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PickupNameOverride);
      }
      if (Type != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Type);
      }
      if (ScheduleId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ScheduleId);
      }
      if (U5 != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(U5);
      }
      if (U6 != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(U6);
      }
      if (U7 != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(U7);
      }
      if (BannerId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BannerId);
      }
      if (U9.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(U9);
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
      if (ScoutId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ScoutId);
      }
      if (BannerIdString.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BannerIdString);
      }
      if (PickupNameOverride.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PickupNameOverride);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Type);
      }
      if (ScheduleId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ScheduleId);
      }
      if (U5 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(U5);
      }
      if (U6 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(U6);
      }
      if (U7 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(U7);
      }
      if (BannerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BannerId);
      }
      if (U9.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(U9);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Scout other) {
      if (other == null) {
        return;
      }
      if (other.ScoutId.Length != 0) {
        ScoutId = other.ScoutId;
      }
      if (other.BannerIdString.Length != 0) {
        BannerIdString = other.BannerIdString;
      }
      if (other.PickupNameOverride.Length != 0) {
        PickupNameOverride = other.PickupNameOverride;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.ScheduleId.Length != 0) {
        ScheduleId = other.ScheduleId;
      }
      if (other.U5 != 0UL) {
        U5 = other.U5;
      }
      if (other.U6 != 0) {
        U6 = other.U6;
      }
      if (other.U7 != 0) {
        U7 = other.U7;
      }
      if (other.BannerId != 0) {
        BannerId = other.BannerId;
      }
      if (other.U9.Length != 0) {
        U9 = other.U9;
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
            ScoutId = input.ReadString();
            break;
          }
          case 18: {
            BannerIdString = input.ReadString();
            break;
          }
          case 26: {
            PickupNameOverride = input.ReadString();
            break;
          }
          case 32: {
            Type = input.ReadUInt32();
            break;
          }
          case 42: {
            ScheduleId = input.ReadString();
            break;
          }
          case 48: {
            U5 = input.ReadUInt64();
            break;
          }
          case 56: {
            U6 = input.ReadUInt32();
            break;
          }
          case 64: {
            U7 = input.ReadUInt32();
            break;
          }
          case 72: {
            BannerId = input.ReadUInt32();
            break;
          }
          case 82: {
            U9 = input.ReadString();
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
            ScoutId = input.ReadString();
            break;
          }
          case 18: {
            BannerIdString = input.ReadString();
            break;
          }
          case 26: {
            PickupNameOverride = input.ReadString();
            break;
          }
          case 32: {
            Type = input.ReadUInt32();
            break;
          }
          case 42: {
            ScheduleId = input.ReadString();
            break;
          }
          case 48: {
            U5 = input.ReadUInt64();
            break;
          }
          case 56: {
            U6 = input.ReadUInt32();
            break;
          }
          case 64: {
            U7 = input.ReadUInt32();
            break;
          }
          case 72: {
            BannerId = input.ReadUInt32();
            break;
          }
          case 82: {
            U9 = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ScoutTable : pb::IMessage<ScoutTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ScoutTable> _parser = new pb::MessageParser<ScoutTable>(() => new ScoutTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ScoutTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.ScoutReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScoutTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScoutTable(ScoutTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScoutTable Clone() {
      return new ScoutTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.Scout> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.Scout.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.Scout> entries_ = new pbc::RepeatedField<global::ReMastersLib.Scout>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.Scout> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ScoutTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ScoutTable other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entries_.Equals(other.entries_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entries_.GetHashCode();
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
      entries_.WriteTo(output, _repeated_entries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      entries_.WriteTo(ref output, _repeated_entries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += entries_.CalculateSize(_repeated_entries_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ScoutTable other) {
      if (other == null) {
        return;
      }
      entries_.Add(other.entries_);
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
            entries_.AddEntriesFrom(input, _repeated_entries_codec);
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
            entries_.AddEntriesFrom(ref input, _repeated_entries_codec);
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
