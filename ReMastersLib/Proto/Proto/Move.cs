// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/Move.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/Move.proto</summary>
  public static partial class MoveReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/Move.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MoveReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBQcm90by9Nb3ZlLnByb3RvEgxSZU1hc3RlcnNMaWIiuAIKBE1vdmUSDwoH",
            "bW92ZV9pZBgBIAEoDRIoCghjYXRlZ29yeRgCIAEoDjIWLlJlTWFzdGVyc0xp",
            "Yi5DYXRlZ29yeRIKCgJ1MxgDIAEoDRIgCgR1c2VyGAQgASgOMhIuUmVNYXN0",
            "ZXJzTGliLlVzZXISIgoFZ3JvdXAYBSABKA4yEy5SZU1hc3RlcnNMaWIuR3Jv",
            "dXASDAoEdHlwZRgGIAEoDRIkCgZ0YXJnZXQYByABKA4yFC5SZU1hc3RlcnNM",
            "aWIuVGFyZ2V0EgoKAnU4GAggASgNEhMKC2dhdWdlX2RyYWluGAkgASgNEg0K",
            "BXBvd2VyGAogASgNEhAKCGFjY3VyYWN5GAsgASgNEgwKBHVzZXMYDCABKA0S",
            "HwoEdGFncxgNIAEoDjIRLlJlTWFzdGVyc0xpYi5UYWciMAoJTW92ZVRhYmxl",
            "EiMKB2VudHJpZXMYASADKAsyEi5SZU1hc3RlcnNMaWIuTW92ZSpQCghDYXRl",
            "Z29yeRIOCgpOb0NhdGVnb3J5EAASDAoIUGh5c2ljYWwQARILCgdTcGVjaWFs",
            "EAISCgoGU3RhdHVzEAMSDQoJVW5pdHlNb3ZlEAQqIAoEVXNlchILCgdQb2tl",
            "bW9uEAASCwoHVHJhaW5lchABKlkKBUdyb3VwEggKBE5vbmUQABIMCghVbmtu",
            "b3duMRABEgsKB1JlZ3VsYXIQAhIICgRTeW5jEAMSCQoFVW5pdHkQBBILCgdN",
            "YXhtb3ZlEAUSCQoFQnVkZHkQBiqrAQoGVGFyZ2V0Eg4KCkFsbHlTaW5nbGUQ",
            "ABILCgdBbGx5QWxsEAESEgoOT3Bwb25lbnRTaW5nbGUQAhIPCgtPcHBvbmVu",
            "dEFsbBADEggKBFNlbGYQBBIOCgpBbGx5UmFuZG9tEAUSEgoOT3Bwb25lbnRS",
            "YW5kb20QBhINCglBbGx5RmllbGQQBxIRCg1PcHBvbmVudEZpZWxkEAgSDwoL",
            "RW50aXJlRmllbGQQCSrJAQoDVGFnEggKBG5vbmUQABIQCgxGb3JjZWRTd2l0",
            "Y2gQARIQCgxTdWRkZW5Td2l0Y2gQAhINCglRdWlja01vdmUQBBILCgdTdXJl",
            "SGl0EAgSBgoCbmEQEBIRCg1Pa1doaWxlRnJvemVuECASEAoMT2tXaGlsZVNs",
            "ZWVwEEASFAoPT25seVdoaWxlQXNsZWVwEIABEgoKBUhlYWxzEIACEgwKB0Fi",
            "c29yYnMQgAQSDgoJQ29udGludWVzEIAIEgsKBlJlY29pbBCAEGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ReMastersLib.Category), typeof(global::ReMastersLib.User), typeof(global::ReMastersLib.Group), typeof(global::ReMastersLib.Target), typeof(global::ReMastersLib.Tag), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.Move), global::ReMastersLib.Move.Parser, new[]{ "MoveId", "Category", "U3", "User", "Group", "Type", "Target", "U8", "GaugeDrain", "Power", "Accuracy", "Uses", "Tags" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.MoveTable), global::ReMastersLib.MoveTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Category {
    [pbr::OriginalName("NoCategory")] NoCategory = 0,
    [pbr::OriginalName("Physical")] Physical = 1,
    [pbr::OriginalName("Special")] Special = 2,
    [pbr::OriginalName("Status")] Status = 3,
    [pbr::OriginalName("UnityMove")] UnityMove = 4,
  }

  public enum User {
    [pbr::OriginalName("Pokemon")] Pokemon = 0,
    [pbr::OriginalName("Trainer")] Trainer = 1,
  }

  public enum Group {
    [pbr::OriginalName("None")] None = 0,
    [pbr::OriginalName("Unknown1")] Unknown1 = 1,
    [pbr::OriginalName("Regular")] Regular = 2,
    [pbr::OriginalName("Sync")] Sync = 3,
    [pbr::OriginalName("Unity")] Unity = 4,
    [pbr::OriginalName("Maxmove")] Maxmove = 5,
    [pbr::OriginalName("Buddy")] Buddy = 6,
  }

  public enum Target {
    [pbr::OriginalName("AllySingle")] AllySingle = 0,
    [pbr::OriginalName("AllyAll")] AllyAll = 1,
    [pbr::OriginalName("OpponentSingle")] OpponentSingle = 2,
    [pbr::OriginalName("OpponentAll")] OpponentAll = 3,
    [pbr::OriginalName("Self")] Self = 4,
    [pbr::OriginalName("AllyRandom")] AllyRandom = 5,
    [pbr::OriginalName("OpponentRandom")] OpponentRandom = 6,
    [pbr::OriginalName("AllyField")] AllyField = 7,
    [pbr::OriginalName("OpponentField")] OpponentField = 8,
    [pbr::OriginalName("EntireField")] EntireField = 9,
  }

  public enum Tag {
    [pbr::OriginalName("none")] None = 0,
    [pbr::OriginalName("ForcedSwitch")] ForcedSwitch = 1,
    [pbr::OriginalName("SuddenSwitch")] SuddenSwitch = 2,
    [pbr::OriginalName("QuickMove")] QuickMove = 4,
    [pbr::OriginalName("SureHit")] SureHit = 8,
    [pbr::OriginalName("na")] Na = 16,
    [pbr::OriginalName("OkWhileFrozen")] OkWhileFrozen = 32,
    [pbr::OriginalName("OkWhileSleep")] OkWhileSleep = 64,
    [pbr::OriginalName("OnlyWhileAsleep")] OnlyWhileAsleep = 128,
    [pbr::OriginalName("Heals")] Heals = 256,
    [pbr::OriginalName("Absorbs")] Absorbs = 512,
    [pbr::OriginalName("Continues")] Continues = 1024,
    [pbr::OriginalName("Recoil")] Recoil = 2048,
  }

  #endregion

  #region Messages
  public sealed partial class Move : pb::IMessage<Move>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Move> _parser = new pb::MessageParser<Move>(() => new Move());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Move> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.MoveReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Move() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Move(Move other) : this() {
      moveId_ = other.moveId_;
      category_ = other.category_;
      u3_ = other.u3_;
      user_ = other.user_;
      group_ = other.group_;
      type_ = other.type_;
      target_ = other.target_;
      u8_ = other.u8_;
      gaugeDrain_ = other.gaugeDrain_;
      power_ = other.power_;
      accuracy_ = other.accuracy_;
      uses_ = other.uses_;
      tags_ = other.tags_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Move Clone() {
      return new Move(this);
    }

    /// <summary>Field number for the "move_id" field.</summary>
    public const int MoveIdFieldNumber = 1;
    private uint moveId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MoveId {
      get { return moveId_; }
      set {
        moveId_ = value;
      }
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 2;
    private global::ReMastersLib.Category category_ = global::ReMastersLib.Category.NoCategory;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ReMastersLib.Category Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "u3" field.</summary>
    public const int U3FieldNumber = 3;
    private uint u3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint U3 {
      get { return u3_; }
      set {
        u3_ = value;
      }
    }

    /// <summary>Field number for the "user" field.</summary>
    public const int UserFieldNumber = 4;
    private global::ReMastersLib.User user_ = global::ReMastersLib.User.Pokemon;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ReMastersLib.User User {
      get { return user_; }
      set {
        user_ = value;
      }
    }

    /// <summary>Field number for the "group" field.</summary>
    public const int GroupFieldNumber = 5;
    private global::ReMastersLib.Group group_ = global::ReMastersLib.Group.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ReMastersLib.Group Group {
      get { return group_; }
      set {
        group_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 6;
    private uint type_;
    /// <summary>
    /// motif_type_name_xx.lsd
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 7;
    private global::ReMastersLib.Target target_ = global::ReMastersLib.Target.AllySingle;
    /// <summary>
    /// move_target_type_xx.lsd
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ReMastersLib.Target Target {
      get { return target_; }
      set {
        target_ = value;
      }
    }

    /// <summary>Field number for the "u8" field.</summary>
    public const int U8FieldNumber = 8;
    private uint u8_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint U8 {
      get { return u8_; }
      set {
        u8_ = value;
      }
    }

    /// <summary>Field number for the "gauge_drain" field.</summary>
    public const int GaugeDrainFieldNumber = 9;
    private uint gaugeDrain_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GaugeDrain {
      get { return gaugeDrain_; }
      set {
        gaugeDrain_ = value;
      }
    }

    /// <summary>Field number for the "power" field.</summary>
    public const int PowerFieldNumber = 10;
    private uint power_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Power {
      get { return power_; }
      set {
        power_ = value;
      }
    }

    /// <summary>Field number for the "accuracy" field.</summary>
    public const int AccuracyFieldNumber = 11;
    private uint accuracy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Accuracy {
      get { return accuracy_; }
      set {
        accuracy_ = value;
      }
    }

    /// <summary>Field number for the "uses" field.</summary>
    public const int UsesFieldNumber = 12;
    private uint uses_;
    /// <summary>
    /// 0 = unlimited
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uses {
      get { return uses_; }
      set {
        uses_ = value;
      }
    }

    /// <summary>Field number for the "tags" field.</summary>
    public const int TagsFieldNumber = 13;
    private global::ReMastersLib.Tag tags_ = global::ReMastersLib.Tag.None;
    /// <summary>
    /// move_tag_xx.lsd
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ReMastersLib.Tag Tags {
      get { return tags_; }
      set {
        tags_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Move);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Move other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MoveId != other.MoveId) return false;
      if (Category != other.Category) return false;
      if (U3 != other.U3) return false;
      if (User != other.User) return false;
      if (Group != other.Group) return false;
      if (Type != other.Type) return false;
      if (Target != other.Target) return false;
      if (U8 != other.U8) return false;
      if (GaugeDrain != other.GaugeDrain) return false;
      if (Power != other.Power) return false;
      if (Accuracy != other.Accuracy) return false;
      if (Uses != other.Uses) return false;
      if (Tags != other.Tags) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MoveId != 0) hash ^= MoveId.GetHashCode();
      if (Category != global::ReMastersLib.Category.NoCategory) hash ^= Category.GetHashCode();
      if (U3 != 0) hash ^= U3.GetHashCode();
      if (User != global::ReMastersLib.User.Pokemon) hash ^= User.GetHashCode();
      if (Group != global::ReMastersLib.Group.None) hash ^= Group.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Target != global::ReMastersLib.Target.AllySingle) hash ^= Target.GetHashCode();
      if (U8 != 0) hash ^= U8.GetHashCode();
      if (GaugeDrain != 0) hash ^= GaugeDrain.GetHashCode();
      if (Power != 0) hash ^= Power.GetHashCode();
      if (Accuracy != 0) hash ^= Accuracy.GetHashCode();
      if (Uses != 0) hash ^= Uses.GetHashCode();
      if (Tags != global::ReMastersLib.Tag.None) hash ^= Tags.GetHashCode();
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
      if (MoveId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MoveId);
      }
      if (Category != global::ReMastersLib.Category.NoCategory) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Category);
      }
      if (U3 != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(U3);
      }
      if (User != global::ReMastersLib.User.Pokemon) {
        output.WriteRawTag(32);
        output.WriteEnum((int) User);
      }
      if (Group != global::ReMastersLib.Group.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Group);
      }
      if (Type != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Type);
      }
      if (Target != global::ReMastersLib.Target.AllySingle) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Target);
      }
      if (U8 != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(U8);
      }
      if (GaugeDrain != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GaugeDrain);
      }
      if (Power != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Power);
      }
      if (Accuracy != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Accuracy);
      }
      if (Uses != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Uses);
      }
      if (Tags != global::ReMastersLib.Tag.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Tags);
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
      if (MoveId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MoveId);
      }
      if (Category != global::ReMastersLib.Category.NoCategory) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Category);
      }
      if (U3 != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(U3);
      }
      if (User != global::ReMastersLib.User.Pokemon) {
        output.WriteRawTag(32);
        output.WriteEnum((int) User);
      }
      if (Group != global::ReMastersLib.Group.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Group);
      }
      if (Type != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Type);
      }
      if (Target != global::ReMastersLib.Target.AllySingle) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Target);
      }
      if (U8 != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(U8);
      }
      if (GaugeDrain != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GaugeDrain);
      }
      if (Power != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Power);
      }
      if (Accuracy != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Accuracy);
      }
      if (Uses != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Uses);
      }
      if (Tags != global::ReMastersLib.Tag.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Tags);
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
      if (MoveId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MoveId);
      }
      if (Category != global::ReMastersLib.Category.NoCategory) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Category);
      }
      if (U3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(U3);
      }
      if (User != global::ReMastersLib.User.Pokemon) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) User);
      }
      if (Group != global::ReMastersLib.Group.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Group);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Type);
      }
      if (Target != global::ReMastersLib.Target.AllySingle) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Target);
      }
      if (U8 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(U8);
      }
      if (GaugeDrain != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GaugeDrain);
      }
      if (Power != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Power);
      }
      if (Accuracy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Accuracy);
      }
      if (Uses != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uses);
      }
      if (Tags != global::ReMastersLib.Tag.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Tags);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Move other) {
      if (other == null) {
        return;
      }
      if (other.MoveId != 0) {
        MoveId = other.MoveId;
      }
      if (other.Category != global::ReMastersLib.Category.NoCategory) {
        Category = other.Category;
      }
      if (other.U3 != 0) {
        U3 = other.U3;
      }
      if (other.User != global::ReMastersLib.User.Pokemon) {
        User = other.User;
      }
      if (other.Group != global::ReMastersLib.Group.None) {
        Group = other.Group;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Target != global::ReMastersLib.Target.AllySingle) {
        Target = other.Target;
      }
      if (other.U8 != 0) {
        U8 = other.U8;
      }
      if (other.GaugeDrain != 0) {
        GaugeDrain = other.GaugeDrain;
      }
      if (other.Power != 0) {
        Power = other.Power;
      }
      if (other.Accuracy != 0) {
        Accuracy = other.Accuracy;
      }
      if (other.Uses != 0) {
        Uses = other.Uses;
      }
      if (other.Tags != global::ReMastersLib.Tag.None) {
        Tags = other.Tags;
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
            MoveId = input.ReadUInt32();
            break;
          }
          case 16: {
            Category = (global::ReMastersLib.Category) input.ReadEnum();
            break;
          }
          case 24: {
            U3 = input.ReadUInt32();
            break;
          }
          case 32: {
            User = (global::ReMastersLib.User) input.ReadEnum();
            break;
          }
          case 40: {
            Group = (global::ReMastersLib.Group) input.ReadEnum();
            break;
          }
          case 48: {
            Type = input.ReadUInt32();
            break;
          }
          case 56: {
            Target = (global::ReMastersLib.Target) input.ReadEnum();
            break;
          }
          case 64: {
            U8 = input.ReadUInt32();
            break;
          }
          case 72: {
            GaugeDrain = input.ReadUInt32();
            break;
          }
          case 80: {
            Power = input.ReadUInt32();
            break;
          }
          case 88: {
            Accuracy = input.ReadUInt32();
            break;
          }
          case 96: {
            Uses = input.ReadUInt32();
            break;
          }
          case 104: {
            Tags = (global::ReMastersLib.Tag) input.ReadEnum();
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
            MoveId = input.ReadUInt32();
            break;
          }
          case 16: {
            Category = (global::ReMastersLib.Category) input.ReadEnum();
            break;
          }
          case 24: {
            U3 = input.ReadUInt32();
            break;
          }
          case 32: {
            User = (global::ReMastersLib.User) input.ReadEnum();
            break;
          }
          case 40: {
            Group = (global::ReMastersLib.Group) input.ReadEnum();
            break;
          }
          case 48: {
            Type = input.ReadUInt32();
            break;
          }
          case 56: {
            Target = (global::ReMastersLib.Target) input.ReadEnum();
            break;
          }
          case 64: {
            U8 = input.ReadUInt32();
            break;
          }
          case 72: {
            GaugeDrain = input.ReadUInt32();
            break;
          }
          case 80: {
            Power = input.ReadUInt32();
            break;
          }
          case 88: {
            Accuracy = input.ReadUInt32();
            break;
          }
          case 96: {
            Uses = input.ReadUInt32();
            break;
          }
          case 104: {
            Tags = (global::ReMastersLib.Tag) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class MoveTable : pb::IMessage<MoveTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MoveTable> _parser = new pb::MessageParser<MoveTable>(() => new MoveTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MoveTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.MoveReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MoveTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MoveTable(MoveTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MoveTable Clone() {
      return new MoveTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.Move> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.Move.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.Move> entries_ = new pbc::RepeatedField<global::ReMastersLib.Move>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.Move> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MoveTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MoveTable other) {
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
    public void MergeFrom(MoveTable other) {
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
