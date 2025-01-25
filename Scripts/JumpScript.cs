using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float forceAmount = 3;
    [SerializeField] int jumpsMax = 1;
    int jumpsRemaining;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        ResetJumps();
    }

    public void TryJumping()
    {
        if (jumpsRemaining > 0)
        {
            jumpsRemaining -= 1;
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * forceAmount, ForceMode2D.Impulse);
    }

    void ResetJumps()
    {
        jumpsRemaining = jumpsMax;
    }

    void OnCollisionEnter2D()
    {
        // TODO: Need to check which surface we collide with before reseting (Don't reset on wall...)
        ResetJumps();
    }


}
