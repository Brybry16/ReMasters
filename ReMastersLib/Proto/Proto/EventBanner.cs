// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/EventBanner.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/EventBanner.proto</summary>
  public static partial class EventBannerReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/EventBanner.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventBannerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcm90by9FdmVudEJhbm5lci5wcm90bxIMUmVNYXN0ZXJzTGliInIKC0V2",
            "ZW50QmFubmVyEhcKD2V2ZW50X2Jhbm5lcl9pZBgBIAEoCRIKCgJ1MhgCIAEo",
            "BRIKCgJ1MxgDIAEoBRITCgtzY2hlZHVsZV9pZBgEIAEoCRIKCgJ1NRgFIAEo",
            "CRIRCgliYW5uZXJfaWQYBiABKAUiPgoQRXZlbnRCYW5uZXJUYWJsZRIqCgdl",
            "bnRyaWVzGAEgAygLMhkuUmVNYXN0ZXJzTGliLkV2ZW50QmFubmVyYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.EventBanner), global::ReMastersLib.EventBanner.Parser, new[]{ "EventBannerId", "U2", "U3", "ScheduleId", "U5", "BannerId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.EventBannerTable), global::ReMastersLib.EventBannerTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EventBanner : pb::IMessage<EventBanner>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EventBanner> _parser = new pb::MessageParser<EventBanner>(() => new EventBanner());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EventBanner> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.EventBannerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventBanner() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventBanner(EventBanner other) : this() {
      eventBannerId_ = other.eventBannerId_;
      u2_ = other.u2_;
      u3_ = other.u3_;
      scheduleId_ = other.scheduleId_;
      u5_ = other.u5_;
      bannerId_ = other.bannerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventBanner Clone() {
      return new EventBanner(this);
    }

    /// <summary>Field number for the "event_banner_id" field.</summary>
    public const int EventBannerIdFieldNumber = 1;
    private string eventBannerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EventBannerId {
      get { return eventBannerId_; }
      set {
        eventBannerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "u2" field.</summary>
    public const int U2FieldNumber = 2;
    private int u2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U2 {
      get { return u2_; }
      set {
        u2_ = value;
      }
    }

    /// <summary>Field number for the "u3" field.</summary>
    public const int U3FieldNumber = 3;
    private int u3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U3 {
      get { return u3_; }
      set {
        u3_ = value;
      }
    }

    /// <summary>Field number for the "schedule_id" field.</summary>
    public const int ScheduleIdFieldNumber = 4;
    private string scheduleId_ = "";
    /// <summary>
    /// Schedule.pb
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
    public const int U5FieldNumber = 5;
    private string u5_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string U5 {
      get { return u5_; }
      set {
        u5_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "banner_id" field.</summary>
    public const int BannerIdFieldNumber = 6;
    private int bannerId_;
    /// <summary>
    /// Banner.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int BannerId {
      get { return bannerId_; }
      set {
        bannerId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EventBanner);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EventBanner other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EventBannerId != other.EventBannerId) return false;
      if (U2 != other.U2) return false;
      if (U3 != other.U3) return false;
      if (ScheduleId != other.ScheduleId) return false;
      if (U5 != other.U5) return false;
      if (BannerId != other.BannerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EventBannerId.Length != 0) hash ^= EventBannerId.GetHashCode();
      if (U2 != 0) hash ^= U2.GetHashCode();
      if (U3 != 0) hash ^= U3.GetHashCode();
      if (ScheduleId.Length != 0) hash ^= ScheduleId.GetHashCode();
      if (U5.Length != 0) hash ^= U5.GetHashCode();
      if (BannerId != 0) hash ^= BannerId.GetHashCode();
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
      if (EventBannerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(EventBannerId);
      }
      if (U2 != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(U2);
      }
      if (U3 != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(U3);
      }
      if (ScheduleId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ScheduleId);
      }
      if (U5.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(U5);
      }
      if (BannerId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(BannerId);
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
      if (EventBannerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(EventBannerId);
      }
      if (U2 != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(U2);
      }
      if (U3 != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(U3);
      }
      if (ScheduleId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ScheduleId);
      }
      if (U5.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(U5);
      }
      if (BannerId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(BannerId);
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
      if (EventBannerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EventBannerId);
      }
      if (U2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U2);
      }
      if (U3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U3);
      }
      if (ScheduleId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ScheduleId);
      }
      if (U5.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(U5);
      }
      if (BannerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BannerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EventBanner other) {
      if (other == null) {
        return;
      }
      if (other.EventBannerId.Length != 0) {
        EventBannerId = other.EventBannerId;
      }
      if (other.U2 != 0) {
        U2 = other.U2;
      }
      if (other.U3 != 0) {
        U3 = other.U3;
      }
      if (other.ScheduleId.Length != 0) {
        ScheduleId = other.ScheduleId;
      }
      if (other.U5.Length != 0) {
        U5 = other.U5;
      }
      if (other.BannerId != 0) {
        BannerId = other.BannerId;
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
            EventBannerId = input.ReadString();
            break;
          }
          case 16: {
            U2 = input.ReadInt32();
            break;
          }
          case 24: {
            U3 = input.ReadInt32();
            break;
          }
          case 34: {
            ScheduleId = input.ReadString();
            break;
          }
          case 42: {
            U5 = input.ReadString();
            break;
          }
          case 48: {
            BannerId = input.ReadInt32();
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
            EventBannerId = input.ReadString();
            break;
          }
          case 16: {
            U2 = input.ReadInt32();
            break;
          }
          case 24: {
            U3 = input.ReadInt32();
            break;
          }
          case 34: {
            ScheduleId = input.ReadString();
            break;
          }
          case 42: {
            U5 = input.ReadString();
            break;
          }
          case 48: {
            BannerId = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class EventBannerTable : pb::IMessage<EventBannerTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EventBannerTable> _parser = new pb::MessageParser<EventBannerTable>(() => new EventBannerTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EventBannerTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.EventBannerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventBannerTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventBannerTable(EventBannerTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventBannerTable Clone() {
      return new EventBannerTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.EventBanner> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.EventBanner.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.EventBanner> entries_ = new pbc::RepeatedField<global::ReMastersLib.EventBanner>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.EventBanner> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EventBannerTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EventBannerTable other) {
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
    public void MergeFrom(EventBannerTable other) {
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