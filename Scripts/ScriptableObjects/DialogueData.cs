using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DialogueData: ScriptableObject
{
    [TextArea]
    public string[] dialogue;
}