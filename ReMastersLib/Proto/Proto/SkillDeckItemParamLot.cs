// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/SkillDeckItemParamLot.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/SkillDeckItemParamLot.proto</summary>
  public static partial class SkillDeckItemParamLotReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/SkillDeckItemParamLot.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SkillDeckItemParamLotReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFQcm90by9Ta2lsbERlY2tJdGVtUGFyYW1Mb3QucHJvdG8SDFJlTWFzdGVy",
            "c0xpYiLiAQoVU2tpbGxEZWNrSXRlbVBhcmFtTG90Eh8KF3NraWxsX2RlY2tf",
            "aXRlbV9udW1fbG90GAEgASgFEjMKDmVxdWlwbWVudF90eXBlGAIgASgOMhsu",
            "UmVNYXN0ZXJzTGliLkVxdWlwbWVudFR5cGUSJAoEc3RhdBgDIAEoDjIWLlJl",
            "TWFzdGVyc0xpYi5JdGVtU3RhdBIUCgxlbnRyeV93ZWlnaHQYBCABKAUSEAoI",
            "bWluX3N0YXQYBSABKAUSEAoIbWF4X3N0YXQYBiABKAUSEwoLaXNfcHJpb3Jp",
            "dHkYByABKAgiUgoaU2tpbGxEZWNrSXRlbVBhcmFtTG90VGFibGUSNAoHZW50",
            "cmllcxgBIAMoCzIjLlJlTWFzdGVyc0xpYi5Ta2lsbERlY2tJdGVtUGFyYW1M",
            "b3QqSQoISXRlbVN0YXQSCAoETm9uZRAAEgYKAmhwEAESBwoDYXRrEAISBwoD",
            "ZGVmEAMSBwoDc3BhEAQSBwoDc3BkEAUSBwoDc3BlEAYqPgoNRXF1aXBtZW50",
            "VHlwZRIJCgVPdGhlchAAEgwKCEJyYWNlbGV0EAESCwoHQmFuZGFuYRACEgcK",
            "A1BpbhADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ReMastersLib.ItemStat), typeof(global::ReMastersLib.EquipmentType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.SkillDeckItemParamLot), global::ReMastersLib.SkillDeckItemParamLot.Parser, new[]{ "SkillDeckItemNumLot", "EquipmentType", "Stat", "EntryWeight", "MinStat", "MaxStat", "IsPriority" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.SkillDeckItemParamLotTable), global::ReMastersLib.SkillDeckItemParamLotTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum ItemStat {
    [pbr::OriginalName("None")] None = 0,
    [pbr::OriginalName("hp")] Hp = 1,
    [pbr::OriginalName("atk")] Atk = 2,
    [pbr::OriginalName("def")] Def = 3,
    [pbr::OriginalName("spa")] Spa = 4,
    [pbr::OriginalName("spd")] Spd = 5,
    [pbr::OriginalName("spe")] Spe = 6,
  }

  public enum EquipmentType {
    [pbr::OriginalName("Other")] Other = 0,
    [pbr::OriginalName("Bracelet")] Bracelet = 1,
    [pbr::OriginalName("Bandana")] Bandana = 2,
    [pbr::OriginalName("Pin")] Pin = 3,
  }

  #endregion

  #region Messages
  public sealed partial class SkillDeckItemParamLot : pb::IMessage<SkillDeckItemParamLot>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SkillDeckItemParamLot> _parser = new pb::MessageParser<SkillDeckItemParamLot>(() => new SkillDeckItemParamLot());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SkillDeckItemParamLot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.SkillDeckItemParamLotReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkillDeckItemParamLot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkillDeckItemParamLot(SkillDeckItemParamLot other) : this() {
      skillDeckItemNumLot_ = other.skillDeckItemNumLot_;
      equipmentType_ = other.equipmentType_;
      stat_ = other.stat_;
      entryWeight_ = other.entryWeight_;
      minStat_ = other.minStat_;
      maxStat_ = other.maxStat_;
      isPriority_ = other.isPriority_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkillDeckItemParamLot Clone() {
      return new SkillDeckItemParamLot(this);
    }

    /// <summary>Field number for the "skill_deck_item_num_lot" field.</summary>
    public const int SkillDeckItemNumLotFieldNumber = 1;
    private int skillDeckItemNumLot_;
    /// <summary>
    /// SkillDeckItemNumLot.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SkillDeckItemNumLot {
      get { return skillDeckItemNumLot_; }
      set {
        skillDeckItemNumLot_ = value;
      }
    }

    /// <summary>Field number for the "equipment_type" field.</summary>
    public const int EquipmentTypeFieldNumber = 2;
    private global::ReMastersLib.EquipmentType equipmentType_ = global::ReMastersLib.EquipmentType.Other;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ReMastersLib.EquipmentType EquipmentType {
      get { return equipmentType_; }
      set {
        equipmentType_ = value;
      }
    }

    /// <summary>Field number for the "stat" field.</summary>
    public const int StatFieldNumber = 3;
    private global::ReMastersLib.ItemStat stat_ = global::ReMastersLib.ItemStat.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ReMastersLib.ItemStat Stat {
      get { return stat_; }
      set {
        stat_ = value;
      }
    }

    /// <summary>Field number for the "entry_weight" field.</summary>
    public const int EntryWeightFieldNumber = 4;
    private int entryWeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int EntryWeight {
      get { return entryWeight_; }
      set {
        entryWeight_ = value;
      }
    }

    /// <summary>Field number for the "min_stat" field.</summary>
    public const int MinStatFieldNumber = 5;
    private int minStat_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MinStat {
      get { return minStat_; }
      set {
        minStat_ = value;
      }
    }

    /// <summary>Field number for the "max_stat" field.</summary>
    public const int MaxStatFieldNumber = 6;
    private int maxStat_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxStat {
      get { return maxStat_; }
      set {
        maxStat_ = value;
      }
    }

    /// <summary>Field number for the "is_priority" field.</summary>
    public const int IsPriorityFieldNumber = 7;
    private bool isPriority_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPriority {
      get { return isPriority_; }
      set {
        isPriority_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SkillDeckItemParamLot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SkillDeckItemParamLot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SkillDeckItemNumLot != other.SkillDeckItemNumLot) return false;
      if (EquipmentType != other.EquipmentType) return false;
      if (Stat != other.Stat) return false;
      if (EntryWeight != other.EntryWeight) return false;
      if (MinStat != other.MinStat) return false;
      if (MaxStat != other.MaxStat) return false;
      if (IsPriority != other.IsPriority) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SkillDeckItemNumLot != 0) hash ^= SkillDeckItemNumLot.GetHashCode();
      if (EquipmentType != global::ReMastersLib.EquipmentType.Other) hash ^= EquipmentType.GetHashCode();
      if (Stat != global::ReMastersLib.ItemStat.None) hash ^= Stat.GetHashCode();
      if (EntryWeight != 0) hash ^= EntryWeight.GetHashCode();
      if (MinStat != 0) hash ^= MinStat.GetHashCode();
      if (MaxStat != 0) hash ^= MaxStat.GetHashCode();
      if (IsPriority != false) hash ^= IsPriority.GetHashCode();
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
      if (SkillDeckItemNumLot != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SkillDeckItemNumLot);
      }
      if (EquipmentType != global::ReMastersLib.EquipmentType.Other) {
        output.WriteRawTag(16);
        output.WriteEnum((int) EquipmentType);
      }
      if (Stat != global::ReMastersLib.ItemStat.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Stat);
      }
      if (EntryWeight != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(EntryWeight);
      }
      if (MinStat != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MinStat);
      }
      if (MaxStat != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MaxStat);
      }
      if (IsPriority != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsPriority);
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
      if (SkillDeckItemNumLot != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SkillDeckItemNumLot);
      }
      if (EquipmentType != global::ReMastersLib.EquipmentType.Other) {
        output.WriteRawTag(16);
        output.WriteEnum((int) EquipmentType);
      }
      if (Stat != global::ReMastersLib.ItemStat.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Stat);
      }
      if (EntryWeight != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(EntryWeight);
      }
      if (MinStat != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MinStat);
      }
      if (MaxStat != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MaxStat);
      }
      if (IsPriority != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsPriority);
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
      if (SkillDeckItemNumLot != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SkillDeckItemNumLot);
      }
      if (EquipmentType != global::ReMastersLib.EquipmentType.Other) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EquipmentType);
      }
      if (Stat != global::ReMastersLib.ItemStat.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Stat);
      }
      if (EntryWeight != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EntryWeight);
      }
      if (MinStat != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MinStat);
      }
      if (MaxStat != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxStat);
      }
      if (IsPriority != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SkillDeckItemParamLot other) {
      if (other == null) {
        return;
      }
      if (other.SkillDeckItemNumLot != 0) {
        SkillDeckItemNumLot = other.SkillDeckItemNumLot;
      }
      if (other.EquipmentType != global::ReMastersLib.EquipmentType.Other) {
        EquipmentType = other.EquipmentType;
      }
      if (other.Stat != global::ReMastersLib.ItemStat.None) {
        Stat = other.Stat;
      }
      if (other.EntryWeight != 0) {
        EntryWeight = other.EntryWeight;
      }
      if (other.MinStat != 0) {
        MinStat = other.MinStat;
      }
      if (other.MaxStat != 0) {
        MaxStat = other.MaxStat;
      }
      if (other.IsPriority != false) {
        IsPriority = other.IsPriority;
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
            SkillDeckItemNumLot = input.ReadInt32();
            break;
          }
          case 16: {
            EquipmentType = (global::ReMastersLib.EquipmentType) input.ReadEnum();
            break;
          }
          case 24: {
            Stat = (global::ReMastersLib.ItemStat) input.ReadEnum();
            break;
          }
          case 32: {
            EntryWeight = input.ReadInt32();
            break;
          }
          case 40: {
            MinStat = input.ReadInt32();
            break;
          }
          case 48: {
            MaxStat = input.ReadInt32();
            break;
          }
          case 56: {
            IsPriority = input.ReadBool();
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
            SkillDeckItemNumLot = input.ReadInt32();
            break;
          }
          case 16: {
            EquipmentType = (global::ReMastersLib.EquipmentType) input.ReadEnum();
            break;
          }
          case 24: {
            Stat = (global::ReMastersLib.ItemStat) input.ReadEnum();
            break;
          }
          case 32: {
            EntryWeight = input.ReadInt32();
            break;
          }
          case 40: {
            MinStat = input.ReadInt32();
            break;
          }
          case 48: {
            MaxStat = input.ReadInt32();
            break;
          }
          case 56: {
            IsPriority = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SkillDeckItemParamLotTable : pb::IMessage<SkillDeckItemParamLotTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SkillDeckItemParamLotTable> _parser = new pb::MessageParser<SkillDeckItemParamLotTable>(() => new SkillDeckItemParamLotTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SkillDeckItemParamLotTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.SkillDeckItemParamLotReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkillDeckItemParamLotTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkillDeckItemParamLotTable(SkillDeckItemParamLotTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkillDeckItemParamLotTable Clone() {
      return new SkillDeckItemParamLotTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.SkillDeckItemParamLot> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.SkillDeckItemParamLot.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.SkillDeckItemParamLot> entries_ = new pbc::RepeatedField<global::ReMastersLib.SkillDeckItemParamLot>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.SkillDeckItemParamLot> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SkillDeckItemParamLotTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SkillDeckItemParamLotTable other) {
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
    public void MergeFrom(SkillDeckItemParamLotTable other) {
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
