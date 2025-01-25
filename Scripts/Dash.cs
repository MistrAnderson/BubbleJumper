using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Dash : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public float speed = 10f;
    public float mx;
    public float dashDistance = 10f;
    bool isDashing;
    float doubleTapTime;
    KeyCode LastKeyCode;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //dash gauche
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (doubleTapTime > Time.time && LastKeyCode == KeyCode.A)
            {
                StartCoroutine(Dashs(-1));
            }
            else
            {
                doubleTapTime = Time.time + 0.3f;
            }
            LastKeyCode = KeyCode.A;
        }
        //dash droite
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (doubleTapTime > Time.time && LastKeyCode == KeyCode.D)
            {
                StartCoroutine(Dashs(1));
            }
            else
            {
                doubleTapTime = Time.time + 0.3f;
            }
            LastKeyCode = KeyCode.D;
        }
    }
    private void FixedUpdate()
    {
        if (!isDashing)
        {
            rb.velocity = new Vector2(mx * speed, rb.velocity.y);
        }
    }
    IEnumerator Dashs (float direction)
    {
        isDashing = true;
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        rb.AddForce(new Vector2(dashDistance * direction, 0f), ForceMode2D.Impulse);
        float gravity = rb.gravityScale;
        rb.gravityScale = 0f;
        yield return new WaitForSeconds(0.4f);
        isDashing = false;
        rb.gravityScale = gravity;
    }
}