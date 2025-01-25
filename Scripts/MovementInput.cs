using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
public class MovementInput : MonoBehaviour
{
    Movement movement;

    private void Awake()
    {
        movement = GetComponent<Movement>();
    }
    void Update()
    {
        float dir = Input.GetAxis("Horizontal");
        movement.Move(dir);
    }
}
