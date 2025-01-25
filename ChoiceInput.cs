using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ChoiceInput : MonoBehaviour
{
    HandleBubbles handler;

    void Awake()
    {
        handler = GetComponent<HandleBubbles>();
        enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            handler.ChangeDialogue(0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            handler.ChangeDialogue(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            handler.ChangeDialogue(2);
        }
    }
}
