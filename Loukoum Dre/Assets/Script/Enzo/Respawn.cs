using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Respawn : MonoBehaviour{

    public Transform destination;
    private void Awake()
    {
        PlayerPrefs.SetInt("Manche", 1);
    }
    public void Start()
    {
        NewLevel(PlayerPrefs.GetInt("Manche",1));
    }

    void NewLevel(int nbManche)
    {
        switch (nbManche) {
            case 1:
                print(PlayerPrefs.GetInt("Manche")); 
                break;
            case 2:
                print(PlayerPrefs.GetInt("Manche"));
                break;
            case 3:
                print(PlayerPrefs.GetInt("Manche"));
                break;
            case 4:
                print(PlayerPrefs.GetInt("Manche"));
                break;
            case 5:
                print(PlayerPrefs.GetInt("Manche"));
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            collision.transform.position = destination.position;
            PlayerPrefs.SetInt("Manche", PlayerPrefs.GetInt("Manche")+1);
            NewLevel(PlayerPrefs.GetInt("Manche"));
        }
    }

}
