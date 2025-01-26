using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnTriggerInteract : MonoBehaviour
{
    HandleBubbles handler;
    ChoiceInput input;

    void Awake()
    {
        handler = GetComponent<HandleBubbles>();
        input = GetComponent<ChoiceInput>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            handler.enabled = true;
            input.enabled = true;
            // And do stuff with UI
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            handler.enabled = false;
            input.enabled = false;
            // And do stuff with UI
        }
    }
}
