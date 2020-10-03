using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlateformDestroyer : MonoBehaviour{
    private bool active = true;

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Player" && active){
            StartCoroutine(PlateformDestroy());
        }
    }

    IEnumerator PlateformDestroy(){
        active = false;
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<Collider2D>().enabled = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        active = true;
    }
}