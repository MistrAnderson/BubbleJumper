using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ChoiceInput : MonoBehaviour
{
    KeyCode[] inputKeys;
    HandleBubbles handler;

    void Awake()
    {
        handler = GetComponent<HandleBubbles>();
        enabled = false;
        InitializeKeys();
    }

    void Update()
    {
        for (int i = 0; i < handler.bubbleSets.Length; i++)
        {
            if (Input.GetKeyDown(inputKeys[i]))
            {
                handler.ChangeDialogue(i);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            handler.DisableBubbles();
        }
    }
    void InitializeKeys()
    {
        inputKeys = new KeyCode[] { KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4, KeyCode.Alpha5, KeyCode.Alpha6 };
    }
}
