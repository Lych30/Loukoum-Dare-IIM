using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class Fall : MonoBehaviour
{
    Rigidbody2D rb;
    Transform tr;
    bool estTombe = false;
    private Vector2 startPos, downPos, difPos;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        tr = gameObject.GetComponent<Transform>();
        rb.gravityScale = 0;
        startPos = transform.position; 
    }
    private void Update()
    {
        if (estTombe)
        {
            transform.position = Vector2.Lerp(transform.position,new Vector2(transform.position.x,startPos.y), 4*Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            rb.gravityScale = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(Wait(0.2f));
        rb.gravityScale = 0;
        StartCoroutine(Wait(1.0f));

        
        
    }
    IEnumerator Wait(float value)
    {
        estTombe = false;
        yield return new WaitForSeconds(value);
        //transform.position = new Vector2(transform.position.x, transform.position.y + 0.01f);
        estTombe = true;
    }
}
