using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlateformDestroyer : MonoBehaviour
{

    private bool active = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && active)
        {

            StartCoroutine(PlateformDestroy());
            StartCoroutine(PlateformActivate());

        }
    }

    IEnumerator PlateformDestroy()
    {
        active = false;
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }

    IEnumerator PlateformActivate()
    {
        yield return new WaitForSeconds(3);
        print("cc");
        gameObject.SetActive(true);
        active = true;
    }
}