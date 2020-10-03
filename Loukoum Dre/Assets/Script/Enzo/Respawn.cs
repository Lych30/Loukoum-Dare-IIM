using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Respawn : MonoBehaviour{

    public Transform destination;
    private int nbManche = 1;

    public void Start()
    {
        NewLevel(nbManche);
    }


    bool active = true;
    public void Update()
    {
        if (active) { StartCoroutine(Zbeub()); }
        
    }


    IEnumerator Zbeub()
    {
        active = false;
        yield return new WaitForSeconds(1.0f);
        print("yo");
        active = true;
    }








    void NewLevel(int nbManche)
    {
        switch (nbManche) {
            case 1:
                print(nbManche);
                
                break;
            case 2:
                print(nbManche);
                break;
            case 3:
                print(nbManche);
                break;
            case 4:
                print(nbManche);
                break;
            case 5:
                print(nbManche);
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            collision.transform.position = destination.position;
            nbManche++;
            NewLevel(nbManche);
        }
    }

}
