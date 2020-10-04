using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer : MonoBehaviour
{
    private bool actif = true;
    public Transform destination;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.transform.position = destination.position;
        }
    }

    void Update()
    {
        if (actif == true)
        {
            StartCoroutine(LazerActif());
        }
    }

    IEnumerator LazerActif()
    {
        actif = false;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<Collider2D>().enabled = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        actif = true;
    }
}
