using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HandlerUI : MonoBehaviour
{
    public static HandlerUI instance;

    [SerializeField] TextMeshProUGUI dialogueText;
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] GameObject dialoguePanel;

    private void Awake()
    {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(this);
        }
    }

    public void ShowDialogue(string[] dialogue, string name)
    {
        nameText.text = name + "...";
        dialogueText.text = "";

        for (int i = 0; i < dialogue.Length; i++)
        {
            dialogueText.text += i+1 + ". " + dialogue[i] + "\n";
        }

        dialoguePanel.SetActive(true);
    }

    public void EndDialogue()
    {
        dialoguePanel.SetActive(false);
    }
}
