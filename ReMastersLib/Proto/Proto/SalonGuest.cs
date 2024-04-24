// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/SalonGuest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/SalonGuest.proto</summary>
  public static partial class SalonGuestReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/SalonGuest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SalonGuestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQcm90by9TYWxvbkd1ZXN0LnByb3RvEgxSZU1hc3RlcnNMaWIirQIKClNh",
            "bG9uR3Vlc3QSFAoMc2Fsb25HdWVzdElkGAEgASgNEhEKCXRyYWluZXJJZBgC",
            "IAEoAxIaChJpbnRlcmFjdFNjcmlwdFBhdGgYAyABKAkSCgoCdTQYBCABKAUS",
            "FAoMc3RvcnlRdWVzdElkGAUgASgDEgoKAnU2GAYgASgEEgoKAnU3GAcgASgJ",
            "EhIKCnNjaGVkdWxlSWQYCCABKAkSCgoCdTkYCSABKAMSCwoDdTEwGAogASgF",
            "EgsKA3UxMRgLIAEoBRILCgN1MTIYDCABKAMSCwoDdTEzGA0gASgDEgsKA3Ux",
            "NBgOIAEoAxILCgN1MTUYDyABKAMSCwoDdTE2GBAgASgDEgsKA3UxNxgRIAEo",
            "AxILCgN1MTgYEiABKAMSCwoDdTE5GBMgASgJIjwKD1NhbG9uR3Vlc3RUYWJs",
            "ZRIpCgdlbnRyaWVzGAEgAygLMhguUmVNYXN0ZXJzTGliLlNhbG9uR3Vlc3Ri",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.SalonGuest), global::ReMastersLib.SalonGuest.Parser, new[]{ "SalonGuestId", "TrainerId", "InteractScriptPath", "U4", "StoryQuestId", "U6", "U7", "ScheduleId", "U9", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.SalonGuestTable), global::ReMastersLib.SalonGuestTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SalonGuest : pb::IMessage<SalonGuest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SalonGuest> _parser = new pb::MessageParser<SalonGuest>(() => new SalonGuest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SalonGuest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.SalonGuestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SalonGuest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SalonGuest(SalonGuest other) : this() {
      salonGuestId_ = other.salonGuestId_;
      trainerId_ = other.trainerId_;
      interactScriptPath_ = other.interactScriptPath_;
      u4_ = other.u4_;
      storyQuestId_ = other.storyQuestId_;
      u6_ = other.u6_;
      u7_ = other.u7_;
      scheduleId_ = other.scheduleId_;
      u9_ = other.u9_;
      u10_ = other.u10_;
      u11_ = other.u11_;
      u12_ = other.u12_;
      u13_ = other.u13_;
      u14_ = other.u14_;
      u15_ = other.u15_;
      u16_ = other.u16_;
      u17_ = other.u17_;
      u18_ = other.u18_;
      u19_ = other.u19_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SalonGuest Clone() {
      return new SalonGuest(this);
    }

    /// <summary>Field number for the "salonGuestId" field.</summary>
    public const int SalonGuestIdFieldNumber = 1;
    private uint salonGuestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SalonGuestId {
      get { return salonGuestId_; }
      set {
        salonGuestId_ = value;
      }
    }

    /// <summary>Field number for the "trainerId" field.</summary>
    public const int TrainerIdFieldNumber = 2;
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

    /// <summary>Field number for the "interactScriptPath" field.</summary>
    public const int InteractScriptPathFieldNumber = 3;
    private string interactScriptPath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string InteractScriptPath {
      get { return interactScriptPath_; }
      set {
        interactScriptPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "u4" field.</summary>
    public const int U4FieldNumber = 4;
    private int u4_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U4 {
      get { return u4_; }
      set {
        u4_ = value;
      }
    }

    /// <summary>Field number for the "storyQuestId" field.</summary>
    public const int StoryQuestIdFieldNumber = 5;
    private long storyQuestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long StoryQuestId {
      get { return storyQuestId_; }
      set {
        storyQuestId_ = value;
      }
    }

    /// <summary>Field number for the "u6" field.</summary>
    public const int U6FieldNumber = 6;
    private ulong u6_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong U6 {
      get { return u6_; }
      set {
        u6_ = value;
      }
    }

    /// <summary>Field number for the "u7" field.</summary>
    public const int U7FieldNumber = 7;
    private string u7_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string U7 {
      get { return u7_; }
      set {
        u7_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "scheduleId" field.</summary>
    public const int ScheduleIdFieldNumber = 8;
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

    /// <summary>Field number for the "u9" field.</summary>
    public const int U9FieldNumber = 9;
    private long u9_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long U9 {
      get { return u9_; }
      set {
        u9_ = value;
      }
    }

    /// <summary>Field number for the "u10" field.</summary>
    public const int U10FieldNumber = 10;
    private int u10_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U10 {
      get { return u10_; }
      set {
        u10_ = value;
      }
    }

    /// <summary>Field number for the "u11" field.</summary>
    public const int U11FieldNumber = 11;
    private int u11_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U11 {
      get { return u11_; }
      set {
        u11_ = value;
      }
    }

    /// <summary>Field number for the "u12" field.</summary>
    public const int U12FieldNumber = 12;
    private long u12_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long U12 {
      get { return u12_; }
      set {
        u12_ = value;
      }
    }

    /// <summary>Field number for the "u13" field.</summary>
    public const int U13FieldNumber = 13;
    private long u13_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long U13 {
      get { return u13_; }
      set {
        u13_ = value;
      }
    }

    /// <summary>Field number for the "u14" field.</summary>
    public const int U14FieldNumber = 14;
    private long u14_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long U14 {
      get { return u14_; }
      set {
        u14_ = value;
      }
    }

    /// <summary>Field number for the "u15" field.</summary>
    public const int U15FieldNumber = 15;
    private long u15_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long U15 {
      get { return u15_; }
      set {
        u15_ = value;
      }
    }

    /// <summary>Field number for the "u16" field.</summary>
    public const int U16FieldNumber = 16;
    private long u16_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long U16 {
      get { return u16_; }
      set {
        u16_ = value;
      }
    }

    /// <summary>Field number for the "u17" field.</summary>
    public const int U17FieldNumber = 17;
    private long u17_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long U17 {
      get { return u17_; }
      set {
        u17_ = value;
      }
    }

    /// <summary>Field number for the "u18" field.</summary>
    public const int U18FieldNumber = 18;
    private long u18_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long U18 {
      get { return u18_; }
      set {
        u18_ = value;
      }
    }

    /// <summary>Field number for the "u19" field.</summary>
    public const int U19FieldNumber = 19;
    private string u19_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string U19 {
      get { return u19_; }
      set {
        u19_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SalonGuest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SalonGuest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SalonGuestId != other.SalonGuestId) return false;
      if (TrainerId != other.TrainerId) return false;
      if (InteractScriptPath != other.InteractScriptPath) return false;
      if (U4 != other.U4) return false;
      if (StoryQuestId != other.StoryQuestId) return false;
      if (U6 != other.U6) return false;
      if (U7 != other.U7) return false;
      if (ScheduleId != other.ScheduleId) return false;
      if (U9 != other.U9) return false;
      if (U10 != other.U10) return false;
      if (U11 != other.U11) return false;
      if (U12 != other.U12) return false;
      if (U13 != other.U13) return false;
      if (U14 != other.U14) return false;
      if (U15 != other.U15) return false;
      if (U16 != other.U16) return false;
      if (U17 != other.U17) return false;
      if (U18 != other.U18) return false;
      if (U19 != other.U19) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SalonGuestId != 0) hash ^= SalonGuestId.GetHashCode();
      if (TrainerId != 0L) hash ^= TrainerId.GetHashCode();
      if (InteractScriptPath.Length != 0) hash ^= InteractScriptPath.GetHashCode();
      if (U4 != 0) hash ^= U4.GetHashCode();
      if (StoryQuestId != 0L) hash ^= StoryQuestId.GetHashCode();
      if (U6 != 0UL) hash ^= U6.GetHashCode();
      if (U7.Length != 0) hash ^= U7.GetHashCode();
      if (ScheduleId.Length != 0) hash ^= ScheduleId.GetHashCode();
      if (U9 != 0L) hash ^= U9.GetHashCode();
      if (U10 != 0) hash ^= U10.GetHashCode();
      if (U11 != 0) hash ^= U11.GetHashCode();
      if (U12 != 0L) hash ^= U12.GetHashCode();
      if (U13 != 0L) hash ^= U13.GetHashCode();
      if (U14 != 0L) hash ^= U14.GetHashCode();
      if (U15 != 0L) hash ^= U15.GetHashCode();
      if (U16 != 0L) hash ^= U16.GetHashCode();
      if (U17 != 0L) hash ^= U17.GetHashCode();
      if (U18 != 0L) hash ^= U18.GetHashCode();
      if (U19.Length != 0) hash ^= U19.GetHashCode();
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
      if (SalonGuestId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SalonGuestId);
      }
      if (TrainerId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(TrainerId);
      }
      if (InteractScriptPath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(InteractScriptPath);
      }
      if (U4 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(U4);
      }
      if (StoryQuestId != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(StoryQuestId);
      }
      if (U6 != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(U6);
      }
      if (U7.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(U7);
      }
      if (ScheduleId.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ScheduleId);
      }
      if (U9 != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(U9);
      }
      if (U10 != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(U10);
      }
      if (U11 != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(U11);
      }
      if (U12 != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(U12);
      }
      if (U13 != 0L) {
        output.WriteRawTag(104);
        output.WriteInt64(U13);
      }
      if (U14 != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(U14);
      }
      if (U15 != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(U15);
      }
      if (U16 != 0L) {
        output.WriteRawTag(128, 1);
        output.WriteInt64(U16);
      }
      if (U17 != 0L) {
        output.WriteRawTag(136, 1);
        output.WriteInt64(U17);
      }
      if (U18 != 0L) {
        output.WriteRawTag(144, 1);
        output.WriteInt64(U18);
      }
      if (U19.Length != 0) {
        output.WriteRawTag(154, 1);
        output.WriteString(U19);
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
      if (SalonGuestId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SalonGuestId);
      }
      if (TrainerId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(TrainerId);
      }
      if (InteractScriptPath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(InteractScriptPath);
      }
      if (U4 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(U4);
      }
      if (StoryQuestId != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(StoryQuestId);
      }
      if (U6 != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(U6);
      }
      if (U7.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(U7);
      }
      if (ScheduleId.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ScheduleId);
      }
      if (U9 != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(U9);
      }
      if (U10 != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(U10);
      }
      if (U11 != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(U11);
      }
      if (U12 != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(U12);
      }
      if (U13 != 0L) {
        output.WriteRawTag(104);
        output.WriteInt64(U13);
      }
      if (U14 != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(U14);
      }
      if (U15 != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(U15);
      }
      if (U16 != 0L) {
        output.WriteRawTag(128, 1);
        output.WriteInt64(U16);
      }
      if (U17 != 0L) {
        output.WriteRawTag(136, 1);
        output.WriteInt64(U17);
      }
      if (U18 != 0L) {
        output.WriteRawTag(144, 1);
        output.WriteInt64(U18);
      }
      if (U19.Length != 0) {
        output.WriteRawTag(154, 1);
        output.WriteString(U19);
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
      if (SalonGuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SalonGuestId);
      }
      if (TrainerId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TrainerId);
      }
      if (InteractScriptPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InteractScriptPath);
      }
      if (U4 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U4);
      }
      if (StoryQuestId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(StoryQuestId);
      }
      if (U6 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(U6);
      }
      if (U7.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(U7);
      }
      if (ScheduleId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ScheduleId);
      }
      if (U9 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(U9);
      }
      if (U10 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U10);
      }
      if (U11 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U11);
      }
      if (U12 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(U12);
      }
      if (U13 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(U13);
      }
      if (U14 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(U14);
      }
      if (U15 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(U15);
      }
      if (U16 != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(U16);
      }
      if (U17 != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(U17);
      }
      if (U18 != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(U18);
      }
      if (U19.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(U19);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SalonGuest other) {
      if (other == null) {
        return;
      }
      if (other.SalonGuestId != 0) {
        SalonGuestId = other.SalonGuestId;
      }
      if (other.TrainerId != 0L) {
        TrainerId = other.TrainerId;
      }
      if (other.InteractScriptPath.Length != 0) {
        InteractScriptPath = other.InteractScriptPath;
      }
      if (other.U4 != 0) {
        U4 = other.U4;
      }
      if (other.StoryQuestId != 0L) {
        StoryQuestId = other.StoryQuestId;
      }
      if (other.U6 != 0UL) {
        U6 = other.U6;
      }
      if (other.U7.Length != 0) {
        U7 = other.U7;
      }
      if (other.ScheduleId.Length != 0) {
        ScheduleId = other.ScheduleId;
      }
      if (other.U9 != 0L) {
        U9 = other.U9;
      }
      if (other.U10 != 0) {
        U10 = other.U10;
      }
      if (other.U11 != 0) {
        U11 = other.U11;
      }
      if (other.U12 != 0L) {
        U12 = other.U12;
      }
      if (other.U13 != 0L) {
        U13 = other.U13;
      }
      if (other.U14 != 0L) {
        U14 = other.U14;
      }
      if (other.U15 != 0L) {
        U15 = other.U15;
      }
      if (other.U16 != 0L) {
        U16 = other.U16;
      }
      if (other.U17 != 0L) {
        U17 = other.U17;
      }
      if (other.U18 != 0L) {
        U18 = other.U18;
      }
      if (other.U19.Length != 0) {
        U19 = other.U19;
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
            SalonGuestId = input.ReadUInt32();
            break;
          }
          case 16: {
            TrainerId = input.ReadInt64();
            break;
          }
          case 26: {
            InteractScriptPath = input.ReadString();
            break;
          }
          case 32: {
            U4 = input.ReadInt32();
            break;
          }
          case 40: {
            StoryQuestId = input.ReadInt64();
            break;
          }
          case 48: {
            U6 = input.ReadUInt64();
            break;
          }
          case 58: {
            U7 = input.ReadString();
            break;
          }
          case 66: {
            ScheduleId = input.ReadString();
            break;
          }
          case 72: {
            U9 = input.ReadInt64();
            break;
          }
          case 80: {
            U10 = input.ReadInt32();
            break;
          }
          case 88: {
            U11 = input.ReadInt32();
            break;
          }
          case 96: {
            U12 = input.ReadInt64();
            break;
          }
          case 104: {
            U13 = input.ReadInt64();
            break;
          }
          case 112: {
            U14 = input.ReadInt64();
            break;
          }
          case 120: {
            U15 = input.ReadInt64();
            break;
          }
          case 128: {
            U16 = input.ReadInt64();
            break;
          }
          case 136: {
            U17 = input.ReadInt64();
            break;
          }
          case 144: {
            U18 = input.ReadInt64();
            break;
          }
          case 154: {
            U19 = input.ReadString();
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
            SalonGuestId = input.ReadUInt32();
            break;
          }
          case 16: {
            TrainerId = input.ReadInt64();
            break;
          }
          case 26: {
            InteractScriptPath = input.ReadString();
            break;
          }
          case 32: {
            U4 = input.ReadInt32();
            break;
          }
          case 40: {
            StoryQuestId = input.ReadInt64();
            break;
          }
          case 48: {
            U6 = input.ReadUInt64();
            break;
          }
          case 58: {
            U7 = input.ReadString();
            break;
          }
          case 66: {
            ScheduleId = input.ReadString();
            break;
          }
          case 72: {
            U9 = input.ReadInt64();
            break;
          }
          case 80: {
            U10 = input.ReadInt32();
            break;
          }
          case 88: {
            U11 = input.ReadInt32();
            break;
          }
          case 96: {
            U12 = input.ReadInt64();
            break;
          }
          case 104: {
            U13 = input.ReadInt64();
            break;
          }
          case 112: {
            U14 = input.ReadInt64();
            break;
          }
          case 120: {
            U15 = input.ReadInt64();
            break;
          }
          case 128: {
            U16 = input.ReadInt64();
            break;
          }
          case 136: {
            U17 = input.ReadInt64();
            break;
          }
          case 144: {
            U18 = input.ReadInt64();
            break;
          }
          case 154: {
            U19 = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SalonGuestTable : pb::IMessage<SalonGuestTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SalonGuestTable> _parser = new pb::MessageParser<SalonGuestTable>(() => new SalonGuestTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SalonGuestTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.SalonGuestReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SalonGuestTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SalonGuestTable(SalonGuestTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SalonGuestTable Clone() {
      return new SalonGuestTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.SalonGuest> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.SalonGuest.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.SalonGuest> entries_ = new pbc::RepeatedField<global::ReMastersLib.SalonGuest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.SalonGuest> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SalonGuestTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SalonGuestTable other) {
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
    public void MergeFrom(SalonGuestTable other) {
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
