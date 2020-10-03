using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float speed;
    public float jumpVelocity = 10f;
    private bool isGrounded = true;
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Jump();
        }
            rb2D.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb2D.velocity.y);
    }

    public void Jump()
    {
        if (isGrounded == true)
        {
            rb2D.velocity = Vector2.up * jumpVelocity;
            isGrounded = false;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") { isGrounded = true; }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") { isGrounded = false; }
    }
}
