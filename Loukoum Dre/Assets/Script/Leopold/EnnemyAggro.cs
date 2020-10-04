using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAggro : MonoBehaviour
{
    private Animator animator;
    SpriteRenderer sprite;
    public int vie = 4;
    private float direction = 1;
    private SpriteRenderer skin;
    //private Animator animatotor;
    [SerializeField]
    Transform player;
    [SerializeField]
    float agroRange;
    [SerializeField]
    float moveSpeed;
    Rigidbody2D rb;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        //animatotor = GetComponent<Animator>();
        skin = GetComponent<SpriteRenderer>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {

       
        if (vie > 0)
        {

            float disToPLayer = Vector2.Distance(transform.position, player.position);
            if (disToPLayer < agroRange)
            {
                ChasePlayer();

            }
            else
            {
                StopChasingPlayer();
            }

        }
        if (vie <= 0)
        {
            Destroy(gameObject);
        }


    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            sprite.color = new Color(1, 0, 0, 1);
            vie -= 1;
            StartCoroutine("attendre");

        }
    }
    void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            rb.velocity = new Vector2(moveSpeed, 0);
            skin.flipX = false;
            animator.SetFloat("Velocity", Mathf.Abs(rb.velocity.x));
        }
        else if (transform.position.x > player.position.x)
        {
            rb.velocity = new Vector2(-moveSpeed, 0);
            skin.flipX = true;
            animator.SetFloat("Velocity", Mathf.Abs(rb.velocity.x));
        }

    }
    void StopChasingPlayer()
    {
        rb.velocity = new Vector2(0, 0);
        //animatotor.SetFloat("velocityX", Mathf.Abs(rb.velocity.x));
    }
    IEnumerator attendre()
    {
        yield return new WaitForSeconds(0.05f);
        sprite.color = new Color(1, 1, 1, 1);
    }
}
