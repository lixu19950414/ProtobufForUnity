using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Google.Protobuf;
using System;

public class ProtoTest : MonoBehaviour {
    public CodedOutputStream outputStream;
    public CodedInputStream inputStream;
    private byte[] outputBuffer;
    private byte[] inputBuffer;

    private void Awake()
    {
        outputBuffer = new byte[1024];
        inputBuffer = new byte[1024];
        outputStream = new CodedOutputStream(outputBuffer);
        inputStream = new CodedInputStream(inputBuffer);
    }

    // Use this for initialization
    void Start () {
        Game.Main.Person p = new Game.Main.Person();
        p.Name = "李旭";
        byte[] databytes = p.ToByteArray();
        Game.Main.Person p1 = new Game.Main.Person();
        p1 = Game.Main.Person.Descriptor.Parser.ParseFrom(databytes) as Game.Main.Person;

        Debug.Log(p1.Name);
    }

    public void PrintMessage(IMessage message)
    {
        var descriptor = message.Descriptor;
        foreach (var field in descriptor.Fields.InDeclarationOrder())
        {
            Debug.LogFormat(
                "Field {0} ({1}): {2}",
                field.FieldNumber,
                field.Name,
                field.Accessor.GetValue(message);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
