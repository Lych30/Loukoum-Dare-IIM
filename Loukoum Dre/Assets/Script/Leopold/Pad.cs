using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
   [Header("Bumper Value")]
   [SerializeField] private float xValue;
   [SerializeField] private float yValue;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xValue, yValue);
        }
    }
}
