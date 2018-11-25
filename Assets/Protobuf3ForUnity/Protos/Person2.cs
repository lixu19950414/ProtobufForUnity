// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: game/Person2.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Game.Main {

  /// <summary>Holder for reflection information generated from game/Person2.proto</summary>
  public static partial class Person2Reflection {

    #region Descriptor
    /// <summary>File descriptor for game/Person2.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Person2Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJnYW1lL1BlcnNvbjIucHJvdG8SCWdhbWUubWFpbhofZ29vZ2xlL3Byb3Rv",
            "YnVmL3RpbWVzdGFtcC5wcm90byKMAgoHUGVyc29uMhIMCgRuYW1lGAEgASgJ",
            "EgoKAmlkGAIgASgFEg0KBWVtYWlsGAMgASgJEi4KBnBob25lcxgEIAMoCzIe",
            "LmdhbWUubWFpbi5QZXJzb24yLlBob25lTnVtYmVyEjAKDGxhc3RfdXBkYXRl",
            "ZBgFIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXAaSQoLUGhvbmVO",
            "dW1iZXISDgoGbnVtYmVyGAEgASgJEioKBHR5cGUYAiABKA4yHC5nYW1lLm1h",
            "aW4uUGVyc29uMi5QaG9uZVR5cGUiKwoJUGhvbmVUeXBlEgoKBk1PQklMRRAA",
            "EggKBEhPTUUQARIICgRXT1JLEAIiMgoMQWRkcmVzc0Jvb2syEiIKBnBlb3Bs",
            "ZRgBIAMoCzISLmdhbWUubWFpbi5QZXJzb24yYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Game.Main.Person2), global::Game.Main.Person2.Parser, new[]{ "Name", "Id", "Email", "Phones", "LastUpdated" }, null, new[]{ typeof(global::Game.Main.Person2.Types.PhoneType) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Game.Main.Person2.Types.PhoneNumber), global::Game.Main.Person2.Types.PhoneNumber.Parser, new[]{ "Number", "Type" }, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Game.Main.AddressBook2), global::Game.Main.AddressBook2.Parser, new[]{ "People" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Person2 : pb::IMessage<Person2> {
    private static readonly pb::MessageParser<Person2> _parser = new pb::MessageParser<Person2>(() => new Person2());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Person2> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Game.Main.Person2Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person2() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person2(Person2 other) : this() {
      name_ = other.name_;
      id_ = other.id_;
      email_ = other.email_;
      phones_ = other.phones_.Clone();
      LastUpdated = other.lastUpdated_ != null ? other.LastUpdated.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person2 Clone() {
      return new Person2(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private int id_;
    /// <summary>
    ///  Unique ID number for this person.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 3;
    private string email_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "phones" field.</summary>
    public const int PhonesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Game.Main.Person2.Types.PhoneNumber> _repeated_phones_codec
        = pb::FieldCodec.ForMessage(34, global::Game.Main.Person2.Types.PhoneNumber.Parser);
    private readonly pbc::RepeatedField<global::Game.Main.Person2.Types.PhoneNumber> phones_ = new pbc::RepeatedField<global::Game.Main.Person2.Types.PhoneNumber>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Game.Main.Person2.Types.PhoneNumber> Phones {
      get { return phones_; }
    }

    /// <summary>Field number for the "last_updated" field.</summary>
    public const int LastUpdatedFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp lastUpdated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LastUpdated {
      get { return lastUpdated_; }
      set {
        lastUpdated_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Person2);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Person2 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if (Email != other.Email) return false;
      if(!phones_.Equals(other.phones_)) return false;
      if (!object.Equals(LastUpdated, other.LastUpdated)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      hash ^= phones_.GetHashCode();
      if (lastUpdated_ != null) hash ^= LastUpdated.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Id);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Email);
      }
      phones_.WriteTo(output, _repeated_phones_codec);
      if (lastUpdated_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(LastUpdated);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      size += phones_.CalculateSize(_repeated_phones_codec);
      if (lastUpdated_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastUpdated);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Person2 other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      phones_.Add(other.phones_);
      if (other.lastUpdated_ != null) {
        if (lastUpdated_ == null) {
          lastUpdated_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LastUpdated.MergeFrom(other.LastUpdated);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt32();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 34: {
            phones_.AddEntriesFrom(input, _repeated_phones_codec);
            break;
          }
          case 42: {
            if (lastUpdated_ == null) {
              lastUpdated_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(lastUpdated_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Person2 message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum PhoneType {
        [pbr::OriginalName("MOBILE")] Mobile = 0,
        [pbr::OriginalName("HOME")] Home = 1,
        [pbr::OriginalName("WORK")] Work = 2,
      }

      public sealed partial class PhoneNumber : pb::IMessage<PhoneNumber> {
        private static readonly pb::MessageParser<PhoneNumber> _parser = new pb::MessageParser<PhoneNumber>(() => new PhoneNumber());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<PhoneNumber> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Game.Main.Person2.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PhoneNumber() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PhoneNumber(PhoneNumber other) : this() {
          number_ = other.number_;
          type_ = other.type_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PhoneNumber Clone() {
          return new PhoneNumber(this);
        }

        /// <summary>Field number for the "number" field.</summary>
        public const int NumberFieldNumber = 1;
        private string number_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Number {
          get { return number_; }
          set {
            number_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 2;
        private global::Game.Main.Person2.Types.PhoneType type_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Game.Main.Person2.Types.PhoneType Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as PhoneNumber);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(PhoneNumber other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Number != other.Number) return false;
          if (Type != other.Type) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Number.Length != 0) hash ^= Number.GetHashCode();
          if (Type != 0) hash ^= Type.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Number.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Number);
          }
          if (Type != 0) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Type);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Number.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Number);
          }
          if (Type != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(PhoneNumber other) {
          if (other == null) {
            return;
          }
          if (other.Number.Length != 0) {
            Number = other.Number;
          }
          if (other.Type != 0) {
            Type = other.Type;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 10: {
                Number = input.ReadString();
                break;
              }
              case 16: {
                type_ = (global::Game.Main.Person2.Types.PhoneType) input.ReadEnum();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  /// <summary>
  ///  Our address book file is just one of these.
  /// </summary>
  public sealed partial class AddressBook2 : pb::IMessage<AddressBook2> {
    private static readonly pb::MessageParser<AddressBook2> _parser = new pb::MessageParser<AddressBook2>(() => new AddressBook2());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressBook2> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Game.Main.Person2Reflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBook2() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBook2(AddressBook2 other) : this() {
      people_ = other.people_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBook2 Clone() {
      return new AddressBook2(this);
    }

    /// <summary>Field number for the "people" field.</summary>
    public const int PeopleFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Game.Main.Person2> _repeated_people_codec
        = pb::FieldCodec.ForMessage(10, global::Game.Main.Person2.Parser);
    private readonly pbc::RepeatedField<global::Game.Main.Person2> people_ = new pbc::RepeatedField<global::Game.Main.Person2>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Game.Main.Person2> People {
      get { return people_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressBook2);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressBook2 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!people_.Equals(other.people_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= people_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      people_.WriteTo(output, _repeated_people_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += people_.CalculateSize(_repeated_people_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressBook2 other) {
      if (other == null) {
        return;
      }
      people_.Add(other.people_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            people_.AddEntriesFrom(input, _repeated_people_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code