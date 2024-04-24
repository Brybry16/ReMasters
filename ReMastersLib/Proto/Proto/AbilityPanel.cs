// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/AbilityPanel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/AbilityPanel.proto</summary>
  public static partial class AbilityPanelReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/AbilityPanel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityPanelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhQcm90by9BYmlsaXR5UGFuZWwucHJvdG8SDFJlTWFzdGVyc0xpYiLMAQoM",
            "QWJpbGl0eVBhbmVsEg8KB2NlbGxfaWQYASABKAUSDwoHdmVyc2lvbhgCIAEo",
            "BRISCgp0cmFpbmVyX2lkGAMgASgDEhMKC2VuZXJneV9jb3N0GAQgASgFEhAK",
            "CG9yYl9jb3N0GAUgASgFEgkKAXgYBiABKAUSCQoBeRgHIAEoBRIJCgF6GAgg",
            "ASgFEhIKCmFiaWxpdHlfaWQYCSABKAMSFQoNY29uZGl0aW9uX2lkcxgKIAMo",
            "BRITCgtzY2hlZHVsZV9pZBgLIAEoCSJAChFBYmlsaXR5UGFuZWxUYWJsZRIr",
            "CgdlbnRyaWVzGAEgAygLMhouUmVNYXN0ZXJzTGliLkFiaWxpdHlQYW5lbGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.AbilityPanel), global::ReMastersLib.AbilityPanel.Parser, new[]{ "CellId", "Version", "TrainerId", "EnergyCost", "OrbCost", "X", "Y", "Z", "AbilityId", "ConditionIds", "ScheduleId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.AbilityPanelTable), global::ReMastersLib.AbilityPanelTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityPanel : pb::IMessage<AbilityPanel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityPanel> _parser = new pb::MessageParser<AbilityPanel>(() => new AbilityPanel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityPanel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.AbilityPanelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityPanel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityPanel(AbilityPanel other) : this() {
      cellId_ = other.cellId_;
      version_ = other.version_;
      trainerId_ = other.trainerId_;
      energyCost_ = other.energyCost_;
      orbCost_ = other.orbCost_;
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      abilityId_ = other.abilityId_;
      conditionIds_ = other.conditionIds_.Clone();
      scheduleId_ = other.scheduleId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityPanel Clone() {
      return new AbilityPanel(this);
    }

    /// <summary>Field number for the "cell_id" field.</summary>
    public const int CellIdFieldNumber = 1;
    private int cellId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CellId {
      get { return cellId_; }
      set {
        cellId_ = value;
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 2;
    private int version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    /// <summary>Field number for the "trainer_id" field.</summary>
    public const int TrainerIdFieldNumber = 3;
    private long trainerId_;
    /// <summary>
    /// Trainer.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long TrainerId {
      get { return trainerId_; }
      set {
        trainerId_ = value;
      }
    }

    /// <summary>Field number for the "energy_cost" field.</summary>
    public const int EnergyCostFieldNumber = 4;
    private int energyCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int EnergyCost {
      get { return energyCost_; }
      set {
        energyCost_ = value;
      }
    }

    /// <summary>Field number for the "orb_cost" field.</summary>
    public const int OrbCostFieldNumber = 5;
    private int orbCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int OrbCost {
      get { return orbCost_; }
      set {
        orbCost_ = value;
      }
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 6;
    private int x_;
    /// <summary>
    /// Hex grid coordinates
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 7;
    private int y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 8;
    private int z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    /// <summary>Field number for the "ability_id" field.</summary>
    public const int AbilityIdFieldNumber = 9;
    private long abilityId_;
    /// <summary>
    /// Ability.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long AbilityId {
      get { return abilityId_; }
      set {
        abilityId_ = value;
      }
    }

    /// <summary>Field number for the "condition_ids" field.</summary>
    public const int ConditionIdsFieldNumber = 10;
    private static readonly pb::FieldCodec<int> _repeated_conditionIds_codec
        = pb::FieldCodec.ForInt32(82);
    private readonly pbc::RepeatedField<int> conditionIds_ = new pbc::RepeatedField<int>();
    /// <summary>
    /// AbilityReleaseCondition.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> ConditionIds {
      get { return conditionIds_; }
    }

    /// <summary>Field number for the "schedule_id" field.</summary>
    public const int ScheduleIdFieldNumber = 11;
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
      return Equals(other as AbilityPanel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityPanel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CellId != other.CellId) return false;
      if (Version != other.Version) return false;
      if (TrainerId != other.TrainerId) return false;
      if (EnergyCost != other.EnergyCost) return false;
      if (OrbCost != other.OrbCost) return false;
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Z != other.Z) return false;
      if (AbilityId != other.AbilityId) return false;
      if(!conditionIds_.Equals(other.conditionIds_)) return false;
      if (ScheduleId != other.ScheduleId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CellId != 0) hash ^= CellId.GetHashCode();
      if (Version != 0) hash ^= Version.GetHashCode();
      if (TrainerId != 0L) hash ^= TrainerId.GetHashCode();
      if (EnergyCost != 0) hash ^= EnergyCost.GetHashCode();
      if (OrbCost != 0) hash ^= OrbCost.GetHashCode();
      if (X != 0) hash ^= X.GetHashCode();
      if (Y != 0) hash ^= Y.GetHashCode();
      if (Z != 0) hash ^= Z.GetHashCode();
      if (AbilityId != 0L) hash ^= AbilityId.GetHashCode();
      hash ^= conditionIds_.GetHashCode();
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
      if (CellId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CellId);
      }
      if (Version != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Version);
      }
      if (TrainerId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(TrainerId);
      }
      if (EnergyCost != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(EnergyCost);
      }
      if (OrbCost != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(OrbCost);
      }
      if (X != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(X);
      }
      if (Y != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Y);
      }
      if (Z != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Z);
      }
      if (AbilityId != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(AbilityId);
      }
      conditionIds_.WriteTo(output, _repeated_conditionIds_codec);
      if (ScheduleId.Length != 0) {
        output.WriteRawTag(90);
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
      if (CellId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CellId);
      }
      if (Version != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Version);
      }
      if (TrainerId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(TrainerId);
      }
      if (EnergyCost != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(EnergyCost);
      }
      if (OrbCost != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(OrbCost);
      }
      if (X != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(X);
      }
      if (Y != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Y);
      }
      if (Z != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Z);
      }
      if (AbilityId != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(AbilityId);
      }
      conditionIds_.WriteTo(ref output, _repeated_conditionIds_codec);
      if (ScheduleId.Length != 0) {
        output.WriteRawTag(90);
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
      if (CellId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CellId);
      }
      if (Version != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Version);
      }
      if (TrainerId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TrainerId);
      }
      if (EnergyCost != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EnergyCost);
      }
      if (OrbCost != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(OrbCost);
      }
      if (X != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(X);
      }
      if (Y != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Y);
      }
      if (Z != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Z);
      }
      if (AbilityId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AbilityId);
      }
      size += conditionIds_.CalculateSize(_repeated_conditionIds_codec);
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
    public void MergeFrom(AbilityPanel other) {
      if (other == null) {
        return;
      }
      if (other.CellId != 0) {
        CellId = other.CellId;
      }
      if (other.Version != 0) {
        Version = other.Version;
      }
      if (other.TrainerId != 0L) {
        TrainerId = other.TrainerId;
      }
      if (other.EnergyCost != 0) {
        EnergyCost = other.EnergyCost;
      }
      if (other.OrbCost != 0) {
        OrbCost = other.OrbCost;
      }
      if (other.X != 0) {
        X = other.X;
      }
      if (other.Y != 0) {
        Y = other.Y;
      }
      if (other.Z != 0) {
        Z = other.Z;
      }
      if (other.AbilityId != 0L) {
        AbilityId = other.AbilityId;
      }
      conditionIds_.Add(other.conditionIds_);
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
            CellId = input.ReadInt32();
            break;
          }
          case 16: {
            Version = input.ReadInt32();
            break;
          }
          case 24: {
            TrainerId = input.ReadInt64();
            break;
          }
          case 32: {
            EnergyCost = input.ReadInt32();
            break;
          }
          case 40: {
            OrbCost = input.ReadInt32();
            break;
          }
          case 48: {
            X = input.ReadInt32();
            break;
          }
          case 56: {
            Y = input.ReadInt32();
            break;
          }
          case 64: {
            Z = input.ReadInt32();
            break;
          }
          case 72: {
            AbilityId = input.ReadInt64();
            break;
          }
          case 82:
          case 80: {
            conditionIds_.AddEntriesFrom(input, _repeated_conditionIds_codec);
            break;
          }
          case 90: {
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
            CellId = input.ReadInt32();
            break;
          }
          case 16: {
            Version = input.ReadInt32();
            break;
          }
          case 24: {
            TrainerId = input.ReadInt64();
            break;
          }
          case 32: {
            EnergyCost = input.ReadInt32();
            break;
          }
          case 40: {
            OrbCost = input.ReadInt32();
            break;
          }
          case 48: {
            X = input.ReadInt32();
            break;
          }
          case 56: {
            Y = input.ReadInt32();
            break;
          }
          case 64: {
            Z = input.ReadInt32();
            break;
          }
          case 72: {
            AbilityId = input.ReadInt64();
            break;
          }
          case 82:
          case 80: {
            conditionIds_.AddEntriesFrom(ref input, _repeated_conditionIds_codec);
            break;
          }
          case 90: {
            ScheduleId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AbilityPanelTable : pb::IMessage<AbilityPanelTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityPanelTable> _parser = new pb::MessageParser<AbilityPanelTable>(() => new AbilityPanelTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityPanelTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.AbilityPanelReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityPanelTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityPanelTable(AbilityPanelTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityPanelTable Clone() {
      return new AbilityPanelTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.AbilityPanel> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.AbilityPanel.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.AbilityPanel> entries_ = new pbc::RepeatedField<global::ReMastersLib.AbilityPanel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.AbilityPanel> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityPanelTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityPanelTable other) {
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
    public void MergeFrom(AbilityPanelTable other) {
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
