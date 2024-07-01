// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DamageChallengeRewardGroup.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from DamageChallengeRewardGroup.proto</summary>
  public static partial class DamageChallengeRewardGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for DamageChallengeRewardGroup.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DamageChallengeRewardGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBEYW1hZ2VDaGFsbGVuZ2VSZXdhcmRHcm91cC5wcm90bxIMUmVNYXN0ZXJz",
            "TGliIq4BChpEYW1hZ2VDaGFsbGVuZ2VSZXdhcmRHcm91cBIbChNkYW1hZ2Vf",
            "Y2hhbGxlbmdlX2lkGAEgASgDEhMKC3Jld2FyZF9zdGVwGAIgASgFEi8KDXJl",
            "cGVhdGVkX3N0ZXAYAyABKA4yGC5SZU1hc3RlcnNMaWIuUmVwZWF0VHlwZRIM",
            "CgRzdGVwGAQgASgDEhMKC2l0ZW1fc2V0X2lkGAUgASgDEgoKAnUxGAYgASgI",
            "IlwKH0RhbWFnZUNoYWxsZW5nZVJld2FyZEdyb3VwVGFibGUSOQoHZW50cmll",
            "cxgBIAMoCzIoLlJlTWFzdGVyc0xpYi5EYW1hZ2VDaGFsbGVuZ2VSZXdhcmRH",
            "cm91cCorCgpSZXBlYXRUeXBlEggKBG5vbmUQABIJCgVmYWxzZRABEggKBHRy",
            "dWUQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ReMastersLib.RepeatType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.DamageChallengeRewardGroup), global::ReMastersLib.DamageChallengeRewardGroup.Parser, new[]{ "DamageChallengeId", "RewardStep", "RepeatedStep", "Step", "ItemSetId", "U1" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.DamageChallengeRewardGroupTable), global::ReMastersLib.DamageChallengeRewardGroupTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum RepeatType {
    [pbr::OriginalName("none")] None = 0,
    [pbr::OriginalName("false")] False = 1,
    [pbr::OriginalName("true")] True = 2,
  }

  #endregion

  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DamageChallengeRewardGroup : pb::IMessage<DamageChallengeRewardGroup>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DamageChallengeRewardGroup> _parser = new pb::MessageParser<DamageChallengeRewardGroup>(() => new DamageChallengeRewardGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DamageChallengeRewardGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.DamageChallengeRewardGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DamageChallengeRewardGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DamageChallengeRewardGroup(DamageChallengeRewardGroup other) : this() {
      damageChallengeId_ = other.damageChallengeId_;
      rewardStep_ = other.rewardStep_;
      repeatedStep_ = other.repeatedStep_;
      step_ = other.step_;
      itemSetId_ = other.itemSetId_;
      u1_ = other.u1_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DamageChallengeRewardGroup Clone() {
      return new DamageChallengeRewardGroup(this);
    }

    /// <summary>Field number for the "damage_challenge_id" field.</summary>
    public const int DamageChallengeIdFieldNumber = 1;
    private long damageChallengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long DamageChallengeId {
      get { return damageChallengeId_; }
      set {
        damageChallengeId_ = value;
      }
    }

    /// <summary>Field number for the "reward_step" field.</summary>
    public const int RewardStepFieldNumber = 2;
    private int rewardStep_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int RewardStep {
      get { return rewardStep_; }
      set {
        rewardStep_ = value;
      }
    }

    /// <summary>Field number for the "repeated_step" field.</summary>
    public const int RepeatedStepFieldNumber = 3;
    private global::ReMastersLib.RepeatType repeatedStep_ = global::ReMastersLib.RepeatType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ReMastersLib.RepeatType RepeatedStep {
      get { return repeatedStep_; }
      set {
        repeatedStep_ = value;
      }
    }

    /// <summary>Field number for the "step" field.</summary>
    public const int StepFieldNumber = 4;
    private long step_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Step {
      get { return step_; }
      set {
        step_ = value;
      }
    }

    /// <summary>Field number for the "item_set_id" field.</summary>
    public const int ItemSetIdFieldNumber = 5;
    private long itemSetId_;
    /// <summary>
    /// ItemSet.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ItemSetId {
      get { return itemSetId_; }
      set {
        itemSetId_ = value;
      }
    }

    /// <summary>Field number for the "u1" field.</summary>
    public const int U1FieldNumber = 6;
    private bool u1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool U1 {
      get { return u1_; }
      set {
        u1_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DamageChallengeRewardGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DamageChallengeRewardGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DamageChallengeId != other.DamageChallengeId) return false;
      if (RewardStep != other.RewardStep) return false;
      if (RepeatedStep != other.RepeatedStep) return false;
      if (Step != other.Step) return false;
      if (ItemSetId != other.ItemSetId) return false;
      if (U1 != other.U1) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DamageChallengeId != 0L) hash ^= DamageChallengeId.GetHashCode();
      if (RewardStep != 0) hash ^= RewardStep.GetHashCode();
      if (RepeatedStep != global::ReMastersLib.RepeatType.None) hash ^= RepeatedStep.GetHashCode();
      if (Step != 0L) hash ^= Step.GetHashCode();
      if (ItemSetId != 0L) hash ^= ItemSetId.GetHashCode();
      if (U1 != false) hash ^= U1.GetHashCode();
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
      if (DamageChallengeId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(DamageChallengeId);
      }
      if (RewardStep != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(RewardStep);
      }
      if (RepeatedStep != global::ReMastersLib.RepeatType.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) RepeatedStep);
      }
      if (Step != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Step);
      }
      if (ItemSetId != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(ItemSetId);
      }
      if (U1 != false) {
        output.WriteRawTag(48);
        output.WriteBool(U1);
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
      if (DamageChallengeId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(DamageChallengeId);
      }
      if (RewardStep != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(RewardStep);
      }
      if (RepeatedStep != global::ReMastersLib.RepeatType.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) RepeatedStep);
      }
      if (Step != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Step);
      }
      if (ItemSetId != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(ItemSetId);
      }
      if (U1 != false) {
        output.WriteRawTag(48);
        output.WriteBool(U1);
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
      if (DamageChallengeId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DamageChallengeId);
      }
      if (RewardStep != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RewardStep);
      }
      if (RepeatedStep != global::ReMastersLib.RepeatType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RepeatedStep);
      }
      if (Step != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Step);
      }
      if (ItemSetId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ItemSetId);
      }
      if (U1 != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DamageChallengeRewardGroup other) {
      if (other == null) {
        return;
      }
      if (other.DamageChallengeId != 0L) {
        DamageChallengeId = other.DamageChallengeId;
      }
      if (other.RewardStep != 0) {
        RewardStep = other.RewardStep;
      }
      if (other.RepeatedStep != global::ReMastersLib.RepeatType.None) {
        RepeatedStep = other.RepeatedStep;
      }
      if (other.Step != 0L) {
        Step = other.Step;
      }
      if (other.ItemSetId != 0L) {
        ItemSetId = other.ItemSetId;
      }
      if (other.U1 != false) {
        U1 = other.U1;
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
            DamageChallengeId = input.ReadInt64();
            break;
          }
          case 16: {
            RewardStep = input.ReadInt32();
            break;
          }
          case 24: {
            RepeatedStep = (global::ReMastersLib.RepeatType) input.ReadEnum();
            break;
          }
          case 32: {
            Step = input.ReadInt64();
            break;
          }
          case 40: {
            ItemSetId = input.ReadInt64();
            break;
          }
          case 48: {
            U1 = input.ReadBool();
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
            DamageChallengeId = input.ReadInt64();
            break;
          }
          case 16: {
            RewardStep = input.ReadInt32();
            break;
          }
          case 24: {
            RepeatedStep = (global::ReMastersLib.RepeatType) input.ReadEnum();
            break;
          }
          case 32: {
            Step = input.ReadInt64();
            break;
          }
          case 40: {
            ItemSetId = input.ReadInt64();
            break;
          }
          case 48: {
            U1 = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DamageChallengeRewardGroupTable : pb::IMessage<DamageChallengeRewardGroupTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DamageChallengeRewardGroupTable> _parser = new pb::MessageParser<DamageChallengeRewardGroupTable>(() => new DamageChallengeRewardGroupTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DamageChallengeRewardGroupTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.DamageChallengeRewardGroupReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DamageChallengeRewardGroupTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DamageChallengeRewardGroupTable(DamageChallengeRewardGroupTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DamageChallengeRewardGroupTable Clone() {
      return new DamageChallengeRewardGroupTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.DamageChallengeRewardGroup> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.DamageChallengeRewardGroup.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.DamageChallengeRewardGroup> entries_ = new pbc::RepeatedField<global::ReMastersLib.DamageChallengeRewardGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.DamageChallengeRewardGroup> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DamageChallengeRewardGroupTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DamageChallengeRewardGroupTable other) {
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
    public void MergeFrom(DamageChallengeRewardGroupTable other) {
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
