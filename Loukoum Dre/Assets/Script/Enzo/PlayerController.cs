using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [Range(1, 10)]
    public float speed = 5.0f;
    [Range(1, 10)]
    public float jumpVelocity = 5.0f;
    private bool isGrounded = true;

    void Start(){
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update(){
        if (Input.GetKeyDown("space")){
            Jump();
        }
        rb2D.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb2D.velocity.y);
    }

    public void Jump(){
        if (isGrounded == true){
            rb2D.velocity = Vector2.up * jumpVelocity;
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Plateforme") { isGrounded = true; }
    }
    private void OnCollisionExit2D(Collision2D collision){
        if (collision.gameObject.tag == "Plateforme") { isGrounded = false; }
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.name == "death"){ transform.position = new Vector2(transform.position.x, 5); }
    }
}
