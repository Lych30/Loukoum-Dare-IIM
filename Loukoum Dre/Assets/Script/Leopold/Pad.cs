using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    [Header("Bumper Value")]
    public Vector2 velocity;
    private bool OnTop;
    private void Start()
    {
        OnTop = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        OnTop = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        OnTop = false;
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && OnTop == true)
        {
            other.gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
        }
    }
}
