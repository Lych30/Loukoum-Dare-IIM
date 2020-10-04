using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb2D;
    [Range(1, 10)]
    public float speed = 5.0f;
    [Range(1, 10)]
    public float jumpVelocity = 5.0f;
    private bool isGrounded = true;
    public Transform respawnPoint;
    private SpriteRenderer sr;

    void Start(){
        animator = GetComponent<Animator>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        transform.position = respawnPoint.position;
    }

    void Update(){
        animator.SetFloat("Velocity",math.abs(rb2D.velocity.x));
        if (Input.GetKeyDown("space")){
            Jump();
        }
        rb2D.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb2D.velocity.y);
        if(rb2D.velocity.x > 0)
        {
            sr.flipX = false;
            //respawnPoint.position = new Vector2(0.072f, respawnPoint.position.y);
        }
        if(rb2D.velocity.x < 0)
        {
            sr.flipX = true;
            //respawnPoint.position = new Vector2(-0.072f, respawnPoint.position.y);
        }
        if (!isGrounded)
        {
            animator.SetBool("is jumping", true);
        }
        print(isGrounded);
    }

    public void Jump(){
        if (isGrounded == true){
            rb2D.velocity = Vector2.up * jumpVelocity;
            isGrounded = false;
            animator.SetBool("is jumping", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Plateforme" || collision.gameObject.tag == "Ground") { isGrounded = true; animator.SetBool("is jumping", false); }
    }
    private void OnCollisionExit2D(Collision2D collision){
        if (collision.gameObject.tag == "Plateforme" || collision.gameObject.tag == "Ground") { isGrounded = false;}
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.name == "death"){ transform.position = new Vector2(transform.position.x, 5); }
    }
}
