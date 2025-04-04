using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(JumpScript))]
public class JumpInput : MonoBehaviour
{
    JumpScript jump;

    void Awake()
    {
        jump = GetComponent<JumpScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump.TryJumping();
        }
    }
}
