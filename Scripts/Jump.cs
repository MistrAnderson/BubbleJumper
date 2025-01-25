using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float forceAmount = 3;
    public void jump()
    {
        rb.AddForce(Vector2.up * forceAmount, ForceMode2D.Impulse);
    }
}
