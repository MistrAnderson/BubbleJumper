using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpInput : MonoBehaviour
{
    Jump jump;
    int jumpNumber = 1;

    private void Awake()
    {
        jump = GetComponent<Jump>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpNumber >= 1)
        {
            jump.jump();
            jumpNumber = jumpNumber - 1;
        }
    }
    void OnCollisionEnter2D()
    {
        if (jumpNumber <= 0)
        {
            jumpNumber = jumpNumber + 1;
        }
    }
}
