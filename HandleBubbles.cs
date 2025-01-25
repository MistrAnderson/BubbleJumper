using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleBubbles : MonoBehaviour
{
    public GameObject[] bubbleSets;
    public static HandleBubbles instance;

    // private void Awake()
    // {
    //     if (instance == null)
    //     {
    //         instance = this;
    //     }
    //     else
    //     {
    //         Destroy(this);
    //     }
    // }

    void Start()
    {
        enabled = false;
    }

    public void ChangeDialogue(int idSet)
    {
        DisableBubbles();
        bubbleSets[idSet].SetActive(true);
    }

    void DisableBubbles()
    {
        foreach (GameObject set in bubbleSets)
        {
            set.SetActive(false);
        }
    }
}
