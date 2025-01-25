using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceInput : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            HandleBubbles.instance.ChangeDialogue(0);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2)) {
            HandleBubbles.instance.ChangeDialogue(1);
        }

        if(Input.GetKeyDown(KeyCode.Alpha3)) {
            HandleBubbles.instance.ChangeDialogue(2);
        }
    }
}
