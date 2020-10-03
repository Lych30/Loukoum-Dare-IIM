using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaToooooorche : MonoBehaviour
{
    public bool activé = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            activé = true;
            Destroy(collision.gameObject);
        }
    }
}
