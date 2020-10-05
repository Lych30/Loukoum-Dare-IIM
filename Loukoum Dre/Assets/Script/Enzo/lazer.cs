using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer : MonoBehaviour
{
    private bool actif = true;
    public Transform destination;
    public ParticleSystem particle1;
    public ParticleSystem particle2;


/*    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.transform.position = destination.position;
        }
    }*/

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
        
        particle1.Stop();
        particle2.Stop();
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<Collider2D>().enabled = true;
        
        particle1.Play();
        particle2.Play();
        actif = true;
    }
}
