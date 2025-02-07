// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/ChampionBattleEventQuest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/ChampionBattleEventQuest.proto</summary>
  public static partial class ChampionBattleEventQuestReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/ChampionBattleEventQuest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChampionBattleEventQuestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRQcm90by9DaGFtcGlvbkJhdHRsZUV2ZW50UXVlc3QucHJvdG8SDFJlTWFz",
            "dGVyc0xpYiJrChhDaGFtcGlvbkJhdHRsZUV2ZW50UXVlc3QSFAoMcXVlc3RH",
            "cm91cElkGAEgASgNEg4KBm51bWJlchgCIAEoDRIQCghiYXR0bGVJZBgDIAEo",
            "BBIXCg9mb3VyS2luZHNSdWxlSWQYBCABKAMiWAodQ2hhbXBpb25CYXR0bGVF",
            "dmVudFF1ZXN0VGFibGUSNwoHZW50cmllcxgBIAMoCzImLlJlTWFzdGVyc0xp",
            "Yi5DaGFtcGlvbkJhdHRsZUV2ZW50UXVlc3RiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.ChampionBattleEventQuest), global::ReMastersLib.ChampionBattleEventQuest.Parser, new[]{ "QuestGroupId", "Number", "BattleId", "FourKindsRuleId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.ChampionBattleEventQuestTable), global::ReMastersLib.ChampionBattleEventQuestTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChampionBattleEventQuest : pb::IMessage<ChampionBattleEventQuest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChampionBattleEventQuest> _parser = new pb::MessageParser<ChampionBattleEventQuest>(() => new ChampionBattleEventQuest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChampionBattleEventQuest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.ChampionBattleEventQuestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleEventQuest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleEventQuest(ChampionBattleEventQuest other) : this() {
      questGroupId_ = other.questGroupId_;
      number_ = other.number_;
      battleId_ = other.battleId_;
      fourKindsRuleId_ = other.fourKindsRuleId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleEventQuest Clone() {
      return new ChampionBattleEventQuest(this);
    }

    /// <summary>Field number for the "questGroupId" field.</summary>
    public const int QuestGroupIdFieldNumber = 1;
    private uint questGroupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QuestGroupId {
      get { return questGroupId_; }
      set {
        questGroupId_ = value;
      }
    }

    /// <summary>Field number for the "number" field.</summary>
    public const int NumberFieldNumber = 2;
    private uint number_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Number {
      get { return number_; }
      set {
        number_ = value;
      }
    }

    /// <summary>Field number for the "battleId" field.</summary>
    public const int BattleIdFieldNumber = 3;
    private ulong battleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong BattleId {
      get { return battleId_; }
      set {
        battleId_ = value;
      }
    }

    /// <summary>Field number for the "fourKindsRuleId" field.</summary>
    public const int FourKindsRuleIdFieldNumber = 4;
    private long fourKindsRuleId_;
    /// <summary>
    /// ChampionBattleEventFourKindsRule.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long FourKindsRuleId {
      get { return fourKindsRuleId_; }
      set {
        fourKindsRuleId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChampionBattleEventQuest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChampionBattleEventQuest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QuestGroupId != other.QuestGroupId) return false;
      if (Number != other.Number) return false;
      if (BattleId != other.BattleId) return false;
      if (FourKindsRuleId != other.FourKindsRuleId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (QuestGroupId != 0) hash ^= QuestGroupId.GetHashCode();
      if (Number != 0) hash ^= Number.GetHashCode();
      if (BattleId != 0UL) hash ^= BattleId.GetHashCode();
      if (FourKindsRuleId != 0L) hash ^= FourKindsRuleId.GetHashCode();
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
      if (QuestGroupId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(QuestGroupId);
      }
      if (Number != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Number);
      }
      if (BattleId != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(BattleId);
      }
      if (FourKindsRuleId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(FourKindsRuleId);
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
      if (QuestGroupId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(QuestGroupId);
      }
      if (Number != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Number);
      }
      if (BattleId != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(BattleId);
      }
      if (FourKindsRuleId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(FourKindsRuleId);
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
      if (QuestGroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestGroupId);
      }
      if (Number != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Number);
      }
      if (BattleId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(BattleId);
      }
      if (FourKindsRuleId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FourKindsRuleId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChampionBattleEventQuest other) {
      if (other == null) {
        return;
      }
      if (other.QuestGroupId != 0) {
        QuestGroupId = other.QuestGroupId;
      }
      if (other.Number != 0) {
        Number = other.Number;
      }
      if (other.BattleId != 0UL) {
        BattleId = other.BattleId;
      }
      if (other.FourKindsRuleId != 0L) {
        FourKindsRuleId = other.FourKindsRuleId;
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
            QuestGroupId = input.ReadUInt32();
            break;
          }
          case 16: {
            Number = input.ReadUInt32();
            break;
          }
          case 24: {
            BattleId = input.ReadUInt64();
            break;
          }
          case 32: {
            FourKindsRuleId = input.ReadInt64();
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
            QuestGroupId = input.ReadUInt32();
            break;
          }
          case 16: {
            Number = input.ReadUInt32();
            break;
          }
          case 24: {
            BattleId = input.ReadUInt64();
            break;
          }
          case 32: {
            FourKindsRuleId = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ChampionBattleEventQuestTable : pb::IMessage<ChampionBattleEventQuestTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChampionBattleEventQuestTable> _parser = new pb::MessageParser<ChampionBattleEventQuestTable>(() => new ChampionBattleEventQuestTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChampionBattleEventQuestTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.ChampionBattleEventQuestReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleEventQuestTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleEventQuestTable(ChampionBattleEventQuestTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleEventQuestTable Clone() {
      return new ChampionBattleEventQuestTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.ChampionBattleEventQuest> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.ChampionBattleEventQuest.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.ChampionBattleEventQuest> entries_ = new pbc::RepeatedField<global::ReMastersLib.ChampionBattleEventQuest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.ChampionBattleEventQuest> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChampionBattleEventQuestTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChampionBattleEventQuestTable other) {
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
    public void MergeFrom(ChampionBattleEventQuestTable other) {
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
