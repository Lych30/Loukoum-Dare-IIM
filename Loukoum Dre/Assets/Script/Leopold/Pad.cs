using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
   [SerializeField] private float xValue;
   [SerializeField] private float yValue;
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xValue, yValue);
        }
    }
}
