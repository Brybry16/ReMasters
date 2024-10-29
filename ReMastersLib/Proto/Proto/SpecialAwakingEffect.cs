// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/SpecialAwakingEffect.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/SpecialAwakingEffect.proto</summary>
  public static partial class SpecialAwakingEffectReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/SpecialAwakingEffect.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpecialAwakingEffectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQcm90by9TcGVjaWFsQXdha2luZ0VmZmVjdC5wcm90bxIMUmVNYXN0ZXJz",
            "TGliIqsBChRTcGVjaWFsQXdha2luZ0VmZmVjdBIhChlzcGVjaWFsX2F3YWtp",
            "bmdfZWZmZWN0X2lkGAEgASgFEh0KFXNwZWNpYWxfYXdha2luZ19sZXZlbBgC",
            "IAEoBRIPCgdyb2xlX2lkGAMgASgFEiQKHHNwZWNpYWxfYXdha2luZ19sZXZl",
            "bF9lZmZlY3QYBCABKAUSDAoEYXJnMRgFIAEoBRIMCgRhcmcyGAYgASgFIlAK",
            "GVNwZWNpYWxBd2FraW5nRWZmZWN0VGFibGUSMwoHZW50cmllcxgBIAMoCzIi",
            "LlJlTWFzdGVyc0xpYi5TcGVjaWFsQXdha2luZ0VmZmVjdGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.SpecialAwakingEffect), global::ReMastersLib.SpecialAwakingEffect.Parser, new[]{ "SpecialAwakingEffectId", "SpecialAwakingLevel", "RoleId", "SpecialAwakingLevelEffect", "Arg1", "Arg2" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.SpecialAwakingEffectTable), global::ReMastersLib.SpecialAwakingEffectTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SpecialAwakingEffect : pb::IMessage<SpecialAwakingEffect>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpecialAwakingEffect> _parser = new pb::MessageParser<SpecialAwakingEffect>(() => new SpecialAwakingEffect());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpecialAwakingEffect> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.SpecialAwakingEffectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpecialAwakingEffect() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpecialAwakingEffect(SpecialAwakingEffect other) : this() {
      specialAwakingEffectId_ = other.specialAwakingEffectId_;
      specialAwakingLevel_ = other.specialAwakingLevel_;
      roleId_ = other.roleId_;
      specialAwakingLevelEffect_ = other.specialAwakingLevelEffect_;
      arg1_ = other.arg1_;
      arg2_ = other.arg2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpecialAwakingEffect Clone() {
      return new SpecialAwakingEffect(this);
    }

    /// <summary>Field number for the "special_awaking_effect_id" field.</summary>
    public const int SpecialAwakingEffectIdFieldNumber = 1;
    private int specialAwakingEffectId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SpecialAwakingEffectId {
      get { return specialAwakingEffectId_; }
      set {
        specialAwakingEffectId_ = value;
      }
    }

    /// <summary>Field number for the "special_awaking_level" field.</summary>
    public const int SpecialAwakingLevelFieldNumber = 2;
    private int specialAwakingLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SpecialAwakingLevel {
      get { return specialAwakingLevel_; }
      set {
        specialAwakingLevel_ = value;
      }
    }

    /// <summary>Field number for the "role_id" field.</summary>
    public const int RoleIdFieldNumber = 3;
    private int roleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int RoleId {
      get { return roleId_; }
      set {
        roleId_ = value;
      }
    }

    /// <summary>Field number for the "special_awaking_level_effect" field.</summary>
    public const int SpecialAwakingLevelEffectFieldNumber = 4;
    private int specialAwakingLevelEffect_;
    /// <summary>
    /// special_awaking_level_effect_description_xx.lsd
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SpecialAwakingLevelEffect {
      get { return specialAwakingLevelEffect_; }
      set {
        specialAwakingLevelEffect_ = value;
      }
    }

    /// <summary>Field number for the "arg1" field.</summary>
    public const int Arg1FieldNumber = 5;
    private int arg1_;
    /// <summary>
    /// stat (7 = all) or multiplier
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Arg1 {
      get { return arg1_; }
      set {
        arg1_ = value;
      }
    }

    /// <summary>Field number for the "arg2" field.</summary>
    public const int Arg2FieldNumber = 6;
    private int arg2_;
    /// <summary>
    /// none or multiplier
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Arg2 {
      get { return arg2_; }
      set {
        arg2_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpecialAwakingEffect);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpecialAwakingEffect other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SpecialAwakingEffectId != other.SpecialAwakingEffectId) return false;
      if (SpecialAwakingLevel != other.SpecialAwakingLevel) return false;
      if (RoleId != other.RoleId) return false;
      if (SpecialAwakingLevelEffect != other.SpecialAwakingLevelEffect) return false;
      if (Arg1 != other.Arg1) return false;
      if (Arg2 != other.Arg2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SpecialAwakingEffectId != 0) hash ^= SpecialAwakingEffectId.GetHashCode();
      if (SpecialAwakingLevel != 0) hash ^= SpecialAwakingLevel.GetHashCode();
      if (RoleId != 0) hash ^= RoleId.GetHashCode();
      if (SpecialAwakingLevelEffect != 0) hash ^= SpecialAwakingLevelEffect.GetHashCode();
      if (Arg1 != 0) hash ^= Arg1.GetHashCode();
      if (Arg2 != 0) hash ^= Arg2.GetHashCode();
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
      if (SpecialAwakingEffectId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SpecialAwakingEffectId);
      }
      if (SpecialAwakingLevel != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(SpecialAwakingLevel);
      }
      if (RoleId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(RoleId);
      }
      if (SpecialAwakingLevelEffect != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(SpecialAwakingLevelEffect);
      }
      if (Arg1 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Arg1);
      }
      if (Arg2 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Arg2);
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
      if (SpecialAwakingEffectId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SpecialAwakingEffectId);
      }
      if (SpecialAwakingLevel != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(SpecialAwakingLevel);
      }
      if (RoleId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(RoleId);
      }
      if (SpecialAwakingLevelEffect != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(SpecialAwakingLevelEffect);
      }
      if (Arg1 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Arg1);
      }
      if (Arg2 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Arg2);
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
      if (SpecialAwakingEffectId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SpecialAwakingEffectId);
      }
      if (SpecialAwakingLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SpecialAwakingLevel);
      }
      if (RoleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoleId);
      }
      if (SpecialAwakingLevelEffect != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SpecialAwakingLevelEffect);
      }
      if (Arg1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Arg1);
      }
      if (Arg2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Arg2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpecialAwakingEffect other) {
      if (other == null) {
        return;
      }
      if (other.SpecialAwakingEffectId != 0) {
        SpecialAwakingEffectId = other.SpecialAwakingEffectId;
      }
      if (other.SpecialAwakingLevel != 0) {
        SpecialAwakingLevel = other.SpecialAwakingLevel;
      }
      if (other.RoleId != 0) {
        RoleId = other.RoleId;
      }
      if (other.SpecialAwakingLevelEffect != 0) {
        SpecialAwakingLevelEffect = other.SpecialAwakingLevelEffect;
      }
      if (other.Arg1 != 0) {
        Arg1 = other.Arg1;
      }
      if (other.Arg2 != 0) {
        Arg2 = other.Arg2;
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
            SpecialAwakingEffectId = input.ReadInt32();
            break;
          }
          case 16: {
            SpecialAwakingLevel = input.ReadInt32();
            break;
          }
          case 24: {
            RoleId = input.ReadInt32();
            break;
          }
          case 32: {
            SpecialAwakingLevelEffect = input.ReadInt32();
            break;
          }
          case 40: {
            Arg1 = input.ReadInt32();
            break;
          }
          case 48: {
            Arg2 = input.ReadInt32();
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
            SpecialAwakingEffectId = input.ReadInt32();
            break;
          }
          case 16: {
            SpecialAwakingLevel = input.ReadInt32();
            break;
          }
          case 24: {
            RoleId = input.ReadInt32();
            break;
          }
          case 32: {
            SpecialAwakingLevelEffect = input.ReadInt32();
            break;
          }
          case 40: {
            Arg1 = input.ReadInt32();
            break;
          }
          case 48: {
            Arg2 = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SpecialAwakingEffectTable : pb::IMessage<SpecialAwakingEffectTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpecialAwakingEffectTable> _parser = new pb::MessageParser<SpecialAwakingEffectTable>(() => new SpecialAwakingEffectTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpecialAwakingEffectTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.SpecialAwakingEffectReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpecialAwakingEffectTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpecialAwakingEffectTable(SpecialAwakingEffectTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpecialAwakingEffectTable Clone() {
      return new SpecialAwakingEffectTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.SpecialAwakingEffect> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.SpecialAwakingEffect.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.SpecialAwakingEffect> entries_ = new pbc::RepeatedField<global::ReMastersLib.SpecialAwakingEffect>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.SpecialAwakingEffect> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpecialAwakingEffectTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpecialAwakingEffectTable other) {
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
    public void MergeFrom(SpecialAwakingEffectTable other) {
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
