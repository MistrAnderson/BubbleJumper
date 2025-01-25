using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public Rigidbody2D rb;
    public float forceAmount = 50;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void dashRight()
    {
        rb.AddForce(Vector2.right * forceAmount, ForceMode2D.Impulse);
    }
    public void dashLeft()
    {
        rb.AddForce(Vector2.left * forceAmount, ForceMode2D.Impulse);
    }
}