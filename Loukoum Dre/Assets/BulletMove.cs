using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float deathTime = 2.0f, bulletSpeed = 5.0f;
    private Rigidbody2D rb;
    public GameObject playerSr;
    void Start()
    {
        Destroy(gameObject, deathTime);
        rb = gameObject.GetComponent<Rigidbody2D>();
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().flipX) { bulletSpeed = -bulletSpeed; }
        else { bulletSpeed = math.abs(bulletSpeed); }
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(bulletSpeed, transform.position.y);
      
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
   
}
