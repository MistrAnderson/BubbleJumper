using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;



public class AnimationSprite : MonoBehaviour
{
    // Start is called before the first frame update
    bool isFacingRight = false;
    JumpScript jumpScript;

    Rigidbody2D rb;
    Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        jumpScript = GetComponent<JumpScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float xVelocity = Input.GetAxis("Horizontal");

        FlipSprite(xVelocity);

        Debug.Log($"xVelocity: {xVelocity}, yVelocity: {rb.velocity.y}");
        animator.SetBool("IsJumping", !jumpScript.isGrounded);
        animator.SetFloat("xVelocity", Mathf.Abs(xVelocity));
        animator.SetFloat("yVelocity", rb.velocity.y);
    }
    
    void FlipSprite(float horizontalInput)
    {
        Debug.LogError("alede animation2");
        if (isFacingRight && horizontalInput > 0f || !isFacingRight && horizontalInput < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
            
        }
    }
}
