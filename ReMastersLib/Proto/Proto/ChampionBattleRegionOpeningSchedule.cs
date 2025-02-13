// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/ChampionBattleRegionOpeningSchedule.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/ChampionBattleRegionOpeningSchedule.proto</summary>
  public static partial class ChampionBattleRegionOpeningScheduleReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/ChampionBattleRegionOpeningSchedule.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChampionBattleRegionOpeningScheduleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9Qcm90by9DaGFtcGlvbkJhdHRsZVJlZ2lvbk9wZW5pbmdTY2hlZHVsZS5w",
            "cm90bxIMUmVNYXN0ZXJzTGliIoABCiNDaGFtcGlvbkJhdHRsZVJlZ2lvbk9w",
            "ZW5pbmdTY2hlZHVsZRIlCh1jaGFtcGlvbkJhdHRsZVJlZ2lvbk9wZW5pbmdJ",
            "ZBgBIAEoDRIeChZjaGFtcGlvbkJhdHRsZVJlZ2lvbklkGAIgASgNEhIKCnNj",
            "aGVkdWxlSWQYAyABKAkibgooQ2hhbXBpb25CYXR0bGVSZWdpb25PcGVuaW5n",
            "U2NoZWR1bGVUYWJsZRJCCgdlbnRyaWVzGAEgAygLMjEuUmVNYXN0ZXJzTGli",
            "LkNoYW1waW9uQmF0dGxlUmVnaW9uT3BlbmluZ1NjaGVkdWxlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.ChampionBattleRegionOpeningSchedule), global::ReMastersLib.ChampionBattleRegionOpeningSchedule.Parser, new[]{ "ChampionBattleRegionOpeningId", "ChampionBattleRegionId", "ScheduleId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.ChampionBattleRegionOpeningScheduleTable), global::ReMastersLib.ChampionBattleRegionOpeningScheduleTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChampionBattleRegionOpeningSchedule : pb::IMessage<ChampionBattleRegionOpeningSchedule>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChampionBattleRegionOpeningSchedule> _parser = new pb::MessageParser<ChampionBattleRegionOpeningSchedule>(() => new ChampionBattleRegionOpeningSchedule());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChampionBattleRegionOpeningSchedule> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.ChampionBattleRegionOpeningScheduleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleRegionOpeningSchedule() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleRegionOpeningSchedule(ChampionBattleRegionOpeningSchedule other) : this() {
      championBattleRegionOpeningId_ = other.championBattleRegionOpeningId_;
      championBattleRegionId_ = other.championBattleRegionId_;
      scheduleId_ = other.scheduleId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleRegionOpeningSchedule Clone() {
      return new ChampionBattleRegionOpeningSchedule(this);
    }

    /// <summary>Field number for the "championBattleRegionOpeningId" field.</summary>
    public const int ChampionBattleRegionOpeningIdFieldNumber = 1;
    private uint championBattleRegionOpeningId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChampionBattleRegionOpeningId {
      get { return championBattleRegionOpeningId_; }
      set {
        championBattleRegionOpeningId_ = value;
      }
    }

    /// <summary>Field number for the "championBattleRegionId" field.</summary>
    public const int ChampionBattleRegionIdFieldNumber = 2;
    private uint championBattleRegionId_;
    /// <summary>
    /// ChampionBattleRegion.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChampionBattleRegionId {
      get { return championBattleRegionId_; }
      set {
        championBattleRegionId_ = value;
      }
    }

    /// <summary>Field number for the "scheduleId" field.</summary>
    public const int ScheduleIdFieldNumber = 3;
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChampionBattleRegionOpeningSchedule);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChampionBattleRegionOpeningSchedule other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChampionBattleRegionOpeningId != other.ChampionBattleRegionOpeningId) return false;
      if (ChampionBattleRegionId != other.ChampionBattleRegionId) return false;
      if (ScheduleId != other.ScheduleId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChampionBattleRegionOpeningId != 0) hash ^= ChampionBattleRegionOpeningId.GetHashCode();
      if (ChampionBattleRegionId != 0) hash ^= ChampionBattleRegionId.GetHashCode();
      if (ScheduleId.Length != 0) hash ^= ScheduleId.GetHashCode();
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
      if (ChampionBattleRegionOpeningId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChampionBattleRegionOpeningId);
      }
      if (ChampionBattleRegionId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ChampionBattleRegionId);
      }
      if (ScheduleId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ScheduleId);
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
      if (ChampionBattleRegionOpeningId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChampionBattleRegionOpeningId);
      }
      if (ChampionBattleRegionId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ChampionBattleRegionId);
      }
      if (ScheduleId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ScheduleId);
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
      if (ChampionBattleRegionOpeningId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChampionBattleRegionOpeningId);
      }
      if (ChampionBattleRegionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChampionBattleRegionId);
      }
      if (ScheduleId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ScheduleId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChampionBattleRegionOpeningSchedule other) {
      if (other == null) {
        return;
      }
      if (other.ChampionBattleRegionOpeningId != 0) {
        ChampionBattleRegionOpeningId = other.ChampionBattleRegionOpeningId;
      }
      if (other.ChampionBattleRegionId != 0) {
        ChampionBattleRegionId = other.ChampionBattleRegionId;
      }
      if (other.ScheduleId.Length != 0) {
        ScheduleId = other.ScheduleId;
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
          case 8: {
            ChampionBattleRegionOpeningId = input.ReadUInt32();
            break;
          }
          case 16: {
            ChampionBattleRegionId = input.ReadUInt32();
            break;
          }
          case 26: {
            ScheduleId = input.ReadString();
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
          case 8: {
            ChampionBattleRegionOpeningId = input.ReadUInt32();
            break;
          }
          case 16: {
            ChampionBattleRegionId = input.ReadUInt32();
            break;
          }
          case 26: {
            ScheduleId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ChampionBattleRegionOpeningScheduleTable : pb::IMessage<ChampionBattleRegionOpeningScheduleTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChampionBattleRegionOpeningScheduleTable> _parser = new pb::MessageParser<ChampionBattleRegionOpeningScheduleTable>(() => new ChampionBattleRegionOpeningScheduleTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChampionBattleRegionOpeningScheduleTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.ChampionBattleRegionOpeningScheduleReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleRegionOpeningScheduleTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleRegionOpeningScheduleTable(ChampionBattleRegionOpeningScheduleTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleRegionOpeningScheduleTable Clone() {
      return new ChampionBattleRegionOpeningScheduleTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.ChampionBattleRegionOpeningSchedule> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.ChampionBattleRegionOpeningSchedule.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.ChampionBattleRegionOpeningSchedule> entries_ = new pbc::RepeatedField<global::ReMastersLib.ChampionBattleRegionOpeningSchedule>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.ChampionBattleRegionOpeningSchedule> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChampionBattleRegionOpeningScheduleTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChampionBattleRegionOpeningScheduleTable other) {
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
    public void MergeFrom(ChampionBattleRegionOpeningScheduleTable other) {
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
