// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/CyclicRankingQuestGroup.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/CyclicRankingQuestGroup.proto</summary>
  public static partial class CyclicRankingQuestGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/CyclicRankingQuestGroup.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CyclicRankingQuestGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNQcm90by9DeWNsaWNSYW5raW5nUXVlc3RHcm91cC5wcm90bxIMUmVNYXN0",
            "ZXJzTGliIn4KF0N5Y2xpY1JhbmtpbmdRdWVzdEdyb3VwEhYKDnF1ZXN0X2dy",
            "b3VwX2lkGAEgASgDEhYKDnN0b3J5X3F1ZXN0X2lkGAIgASgDEiAKGGN5Y2xp",
            "Y19yYW5raW5nX3F1ZXN0X251bRgDIAEoBRIRCgliYW5uZXJfaWQYBCABKAUi",
            "VgocQ3ljbGljUmFua2luZ1F1ZXN0R3JvdXBUYWJsZRI2CgdlbnRyaWVzGAEg",
            "AygLMiUuUmVNYXN0ZXJzTGliLkN5Y2xpY1JhbmtpbmdRdWVzdEdyb3VwYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.CyclicRankingQuestGroup), global::ReMastersLib.CyclicRankingQuestGroup.Parser, new[]{ "QuestGroupId", "StoryQuestId", "CyclicRankingQuestNum", "BannerId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.CyclicRankingQuestGroupTable), global::ReMastersLib.CyclicRankingQuestGroupTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CyclicRankingQuestGroup : pb::IMessage<CyclicRankingQuestGroup>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CyclicRankingQuestGroup> _parser = new pb::MessageParser<CyclicRankingQuestGroup>(() => new CyclicRankingQuestGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CyclicRankingQuestGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.CyclicRankingQuestGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CyclicRankingQuestGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CyclicRankingQuestGroup(CyclicRankingQuestGroup other) : this() {
      questGroupId_ = other.questGroupId_;
      storyQuestId_ = other.storyQuestId_;
      cyclicRankingQuestNum_ = other.cyclicRankingQuestNum_;
      bannerId_ = other.bannerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CyclicRankingQuestGroup Clone() {
      return new CyclicRankingQuestGroup(this);
    }

    /// <summary>Field number for the "quest_group_id" field.</summary>
    public const int QuestGroupIdFieldNumber = 1;
    private long questGroupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long QuestGroupId {
      get { return questGroupId_; }
      set {
        questGroupId_ = value;
      }
    }

    /// <summary>Field number for the "story_quest_id" field.</summary>
    public const int StoryQuestIdFieldNumber = 2;
    private long storyQuestId_;
    /// <summary>
    /// StoryQuest.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long StoryQuestId {
      get { return storyQuestId_; }
      set {
        storyQuestId_ = value;
      }
    }

    /// <summary>Field number for the "cyclic_ranking_quest_num" field.</summary>
    public const int CyclicRankingQuestNumFieldNumber = 3;
    private int cyclicRankingQuestNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CyclicRankingQuestNum {
      get { return cyclicRankingQuestNum_; }
      set {
        cyclicRankingQuestNum_ = value;
      }
    }

    /// <summary>Field number for the "banner_id" field.</summary>
    public const int BannerIdFieldNumber = 4;
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
      return Equals(other as CyclicRankingQuestGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CyclicRankingQuestGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QuestGroupId != other.QuestGroupId) return false;
      if (StoryQuestId != other.StoryQuestId) return false;
      if (CyclicRankingQuestNum != other.CyclicRankingQuestNum) return false;
      if (BannerId != other.BannerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (QuestGroupId != 0L) hash ^= QuestGroupId.GetHashCode();
      if (StoryQuestId != 0L) hash ^= StoryQuestId.GetHashCode();
      if (CyclicRankingQuestNum != 0) hash ^= CyclicRankingQuestNum.GetHashCode();
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
      if (QuestGroupId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(QuestGroupId);
      }
      if (StoryQuestId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(StoryQuestId);
      }
      if (CyclicRankingQuestNum != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(CyclicRankingQuestNum);
      }
      if (BannerId != 0) {
        output.WriteRawTag(32);
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
      if (QuestGroupId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(QuestGroupId);
      }
      if (StoryQuestId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(StoryQuestId);
      }
      if (CyclicRankingQuestNum != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(CyclicRankingQuestNum);
      }
      if (BannerId != 0) {
        output.WriteRawTag(32);
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
      if (QuestGroupId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(QuestGroupId);
      }
      if (StoryQuestId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(StoryQuestId);
      }
      if (CyclicRankingQuestNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CyclicRankingQuestNum);
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
    public void MergeFrom(CyclicRankingQuestGroup other) {
      if (other == null) {
        return;
      }
      if (other.QuestGroupId != 0L) {
        QuestGroupId = other.QuestGroupId;
      }
      if (other.StoryQuestId != 0L) {
        StoryQuestId = other.StoryQuestId;
      }
      if (other.CyclicRankingQuestNum != 0) {
        CyclicRankingQuestNum = other.CyclicRankingQuestNum;
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
          case 8: {
            QuestGroupId = input.ReadInt64();
            break;
          }
          case 16: {
            StoryQuestId = input.ReadInt64();
            break;
          }
          case 24: {
            CyclicRankingQuestNum = input.ReadInt32();
            break;
          }
          case 32: {
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
          case 8: {
            QuestGroupId = input.ReadInt64();
            break;
          }
          case 16: {
            StoryQuestId = input.ReadInt64();
            break;
          }
          case 24: {
            CyclicRankingQuestNum = input.ReadInt32();
            break;
          }
          case 32: {
            BannerId = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CyclicRankingQuestGroupTable : pb::IMessage<CyclicRankingQuestGroupTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CyclicRankingQuestGroupTable> _parser = new pb::MessageParser<CyclicRankingQuestGroupTable>(() => new CyclicRankingQuestGroupTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CyclicRankingQuestGroupTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.CyclicRankingQuestGroupReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CyclicRankingQuestGroupTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CyclicRankingQuestGroupTable(CyclicRankingQuestGroupTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CyclicRankingQuestGroupTable Clone() {
      return new CyclicRankingQuestGroupTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.CyclicRankingQuestGroup> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.CyclicRankingQuestGroup.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.CyclicRankingQuestGroup> entries_ = new pbc::RepeatedField<global::ReMastersLib.CyclicRankingQuestGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.CyclicRankingQuestGroup> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CyclicRankingQuestGroupTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CyclicRankingQuestGroupTable other) {
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
    public void MergeFrom(CyclicRankingQuestGroupTable other) {
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
