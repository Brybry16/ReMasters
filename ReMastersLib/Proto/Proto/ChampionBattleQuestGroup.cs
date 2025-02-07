// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/ChampionBattleQuestGroup.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/ChampionBattleQuestGroup.proto</summary>
  public static partial class ChampionBattleQuestGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/ChampionBattleQuestGroup.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChampionBattleQuestGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRQcm90by9DaGFtcGlvbkJhdHRsZVF1ZXN0R3JvdXAucHJvdG8SDFJlTWFz",
            "dGVyc0xpYiLrAQoYQ2hhbXBpb25CYXR0bGVRdWVzdEdyb3VwEhQKDHF1ZXN0",
            "R3JvdXBJZBgBIAEoDRIeChZjaGFtcGlvbkJhdHRsZVJlZ2lvbklkGAIgASgN",
            "EgoKAnUzGAMgASgNEhYKDnF1ZXN0R3JvdXBOYW1lGAQgASgJEhgKEHJlY29t",
            "bWVuZGVkTGV2ZWwYBSABKA0SCgoCdTYYBiABKA0SCgoCdTcYByABKA0SCgoC",
            "dTgYCCABKAkSCgoCdTkYCSABKAkSFAoMZW1ibGVtSXRlbUlkGAogASgEEhUK",
            "DXBvaW50c1BlckFyZWEYCyABKA0iWAodQ2hhbXBpb25CYXR0bGVRdWVzdEdy",
            "b3VwVGFibGUSNwoHZW50cmllcxgBIAMoCzImLlJlTWFzdGVyc0xpYi5DaGFt",
            "cGlvbkJhdHRsZVF1ZXN0R3JvdXBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.ChampionBattleQuestGroup), global::ReMastersLib.ChampionBattleQuestGroup.Parser, new[]{ "QuestGroupId", "ChampionBattleRegionId", "U3", "QuestGroupName", "RecommendedLevel", "U6", "U7", "U8", "U9", "EmblemItemId", "PointsPerArea" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.ChampionBattleQuestGroupTable), global::ReMastersLib.ChampionBattleQuestGroupTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChampionBattleQuestGroup : pb::IMessage<ChampionBattleQuestGroup>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChampionBattleQuestGroup> _parser = new pb::MessageParser<ChampionBattleQuestGroup>(() => new ChampionBattleQuestGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChampionBattleQuestGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.ChampionBattleQuestGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleQuestGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleQuestGroup(ChampionBattleQuestGroup other) : this() {
      questGroupId_ = other.questGroupId_;
      championBattleRegionId_ = other.championBattleRegionId_;
      u3_ = other.u3_;
      questGroupName_ = other.questGroupName_;
      recommendedLevel_ = other.recommendedLevel_;
      u6_ = other.u6_;
      u7_ = other.u7_;
      u8_ = other.u8_;
      u9_ = other.u9_;
      emblemItemId_ = other.emblemItemId_;
      pointsPerArea_ = other.pointsPerArea_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleQuestGroup Clone() {
      return new ChampionBattleQuestGroup(this);
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

    /// <summary>Field number for the "u3" field.</summary>
    public const int U3FieldNumber = 3;
    private uint u3_;
    /// <summary>
    /// ?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint U3 {
      get { return u3_; }
      set {
        u3_ = value;
      }
    }

    /// <summary>Field number for the "questGroupName" field.</summary>
    public const int QuestGroupNameFieldNumber = 4;
    private string questGroupName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string QuestGroupName {
      get { return questGroupName_; }
      set {
        questGroupName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "recommendedLevel" field.</summary>
    public const int RecommendedLevelFieldNumber = 5;
    private uint recommendedLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RecommendedLevel {
      get { return recommendedLevel_; }
      set {
        recommendedLevel_ = value;
      }
    }

    /// <summary>Field number for the "u6" field.</summary>
    public const int U6FieldNumber = 6;
    private uint u6_;
    /// <summary>
    /// ?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint U6 {
      get { return u6_; }
      set {
        u6_ = value;
      }
    }

    /// <summary>Field number for the "u7" field.</summary>
    public const int U7FieldNumber = 7;
    private uint u7_;
    /// <summary>
    /// ?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint U7 {
      get { return u7_; }
      set {
        u7_ = value;
      }
    }

    /// <summary>Field number for the "u8" field.</summary>
    public const int U8FieldNumber = 8;
    private string u8_ = "";
    /// <summary>
    /// ?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string U8 {
      get { return u8_; }
      set {
        u8_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "u9" field.</summary>
    public const int U9FieldNumber = 9;
    private string u9_ = "";
    /// <summary>
    /// ?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string U9 {
      get { return u9_; }
      set {
        u9_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "emblemItemId" field.</summary>
    public const int EmblemItemIdFieldNumber = 10;
    private ulong emblemItemId_;
    /// <summary>
    /// EmblemItem.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong EmblemItemId {
      get { return emblemItemId_; }
      set {
        emblemItemId_ = value;
      }
    }

    /// <summary>Field number for the "pointsPerArea" field.</summary>
    public const int PointsPerAreaFieldNumber = 11;
    private uint pointsPerArea_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PointsPerArea {
      get { return pointsPerArea_; }
      set {
        pointsPerArea_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChampionBattleQuestGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChampionBattleQuestGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QuestGroupId != other.QuestGroupId) return false;
      if (ChampionBattleRegionId != other.ChampionBattleRegionId) return false;
      if (U3 != other.U3) return false;
      if (QuestGroupName != other.QuestGroupName) return false;
      if (RecommendedLevel != other.RecommendedLevel) return false;
      if (U6 != other.U6) return false;
      if (U7 != other.U7) return false;
      if (U8 != other.U8) return false;
      if (U9 != other.U9) return false;
      if (EmblemItemId != other.EmblemItemId) return false;
      if (PointsPerArea != other.PointsPerArea) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (QuestGroupId != 0) hash ^= QuestGroupId.GetHashCode();
      if (ChampionBattleRegionId != 0) hash ^= ChampionBattleRegionId.GetHashCode();
      if (U3 != 0) hash ^= U3.GetHashCode();
      if (QuestGroupName.Length != 0) hash ^= QuestGroupName.GetHashCode();
      if (RecommendedLevel != 0) hash ^= RecommendedLevel.GetHashCode();
      if (U6 != 0) hash ^= U6.GetHashCode();
      if (U7 != 0) hash ^= U7.GetHashCode();
      if (U8.Length != 0) hash ^= U8.GetHashCode();
      if (U9.Length != 0) hash ^= U9.GetHashCode();
      if (EmblemItemId != 0UL) hash ^= EmblemItemId.GetHashCode();
      if (PointsPerArea != 0) hash ^= PointsPerArea.GetHashCode();
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
      if (ChampionBattleRegionId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ChampionBattleRegionId);
      }
      if (U3 != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(U3);
      }
      if (QuestGroupName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(QuestGroupName);
      }
      if (RecommendedLevel != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RecommendedLevel);
      }
      if (U6 != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(U6);
      }
      if (U7 != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(U7);
      }
      if (U8.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(U8);
      }
      if (U9.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(U9);
      }
      if (EmblemItemId != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(EmblemItemId);
      }
      if (PointsPerArea != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PointsPerArea);
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
      if (ChampionBattleRegionId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ChampionBattleRegionId);
      }
      if (U3 != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(U3);
      }
      if (QuestGroupName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(QuestGroupName);
      }
      if (RecommendedLevel != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RecommendedLevel);
      }
      if (U6 != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(U6);
      }
      if (U7 != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(U7);
      }
      if (U8.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(U8);
      }
      if (U9.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(U9);
      }
      if (EmblemItemId != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(EmblemItemId);
      }
      if (PointsPerArea != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PointsPerArea);
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
      if (ChampionBattleRegionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChampionBattleRegionId);
      }
      if (U3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(U3);
      }
      if (QuestGroupName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(QuestGroupName);
      }
      if (RecommendedLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RecommendedLevel);
      }
      if (U6 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(U6);
      }
      if (U7 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(U7);
      }
      if (U8.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(U8);
      }
      if (U9.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(U9);
      }
      if (EmblemItemId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(EmblemItemId);
      }
      if (PointsPerArea != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointsPerArea);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChampionBattleQuestGroup other) {
      if (other == null) {
        return;
      }
      if (other.QuestGroupId != 0) {
        QuestGroupId = other.QuestGroupId;
      }
      if (other.ChampionBattleRegionId != 0) {
        ChampionBattleRegionId = other.ChampionBattleRegionId;
      }
      if (other.U3 != 0) {
        U3 = other.U3;
      }
      if (other.QuestGroupName.Length != 0) {
        QuestGroupName = other.QuestGroupName;
      }
      if (other.RecommendedLevel != 0) {
        RecommendedLevel = other.RecommendedLevel;
      }
      if (other.U6 != 0) {
        U6 = other.U6;
      }
      if (other.U7 != 0) {
        U7 = other.U7;
      }
      if (other.U8.Length != 0) {
        U8 = other.U8;
      }
      if (other.U9.Length != 0) {
        U9 = other.U9;
      }
      if (other.EmblemItemId != 0UL) {
        EmblemItemId = other.EmblemItemId;
      }
      if (other.PointsPerArea != 0) {
        PointsPerArea = other.PointsPerArea;
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
            ChampionBattleRegionId = input.ReadUInt32();
            break;
          }
          case 24: {
            U3 = input.ReadUInt32();
            break;
          }
          case 34: {
            QuestGroupName = input.ReadString();
            break;
          }
          case 40: {
            RecommendedLevel = input.ReadUInt32();
            break;
          }
          case 48: {
            U6 = input.ReadUInt32();
            break;
          }
          case 56: {
            U7 = input.ReadUInt32();
            break;
          }
          case 66: {
            U8 = input.ReadString();
            break;
          }
          case 74: {
            U9 = input.ReadString();
            break;
          }
          case 80: {
            EmblemItemId = input.ReadUInt64();
            break;
          }
          case 88: {
            PointsPerArea = input.ReadUInt32();
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
            ChampionBattleRegionId = input.ReadUInt32();
            break;
          }
          case 24: {
            U3 = input.ReadUInt32();
            break;
          }
          case 34: {
            QuestGroupName = input.ReadString();
            break;
          }
          case 40: {
            RecommendedLevel = input.ReadUInt32();
            break;
          }
          case 48: {
            U6 = input.ReadUInt32();
            break;
          }
          case 56: {
            U7 = input.ReadUInt32();
            break;
          }
          case 66: {
            U8 = input.ReadString();
            break;
          }
          case 74: {
            U9 = input.ReadString();
            break;
          }
          case 80: {
            EmblemItemId = input.ReadUInt64();
            break;
          }
          case 88: {
            PointsPerArea = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ChampionBattleQuestGroupTable : pb::IMessage<ChampionBattleQuestGroupTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChampionBattleQuestGroupTable> _parser = new pb::MessageParser<ChampionBattleQuestGroupTable>(() => new ChampionBattleQuestGroupTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChampionBattleQuestGroupTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.ChampionBattleQuestGroupReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleQuestGroupTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleQuestGroupTable(ChampionBattleQuestGroupTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChampionBattleQuestGroupTable Clone() {
      return new ChampionBattleQuestGroupTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.ChampionBattleQuestGroup> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.ChampionBattleQuestGroup.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.ChampionBattleQuestGroup> entries_ = new pbc::RepeatedField<global::ReMastersLib.ChampionBattleQuestGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.ChampionBattleQuestGroup> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChampionBattleQuestGroupTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChampionBattleQuestGroupTable other) {
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
    public void MergeFrom(ChampionBattleQuestGroupTable other) {
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
