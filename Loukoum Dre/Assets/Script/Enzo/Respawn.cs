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

    void manche1()
    {
        print("obj manche1");
    }
    void manche2()
    {
        manche1();
        print("obj manche2");
    }
    void manche3()
    {
        manche1();
        manche2();
        print("obj manche3");
    }
    void manche4()
    {
        manche1(); 
        manche2(); 
        manche3();
        print("obj manche4");
    }
    void manche5()
    {
        manche1();
        manche2();
        manche3();
        manche4();
        print("obj manche5");
    }
    void manche6()
    {
        manche1();
        manche2();
        manche3();
        manche4();
        manche5();
        print("obj manche6");
    }






    void NewLevel(int nbManche)
    {
        switch (nbManche) {
            case 1:
                print(PlayerPrefs.GetInt("Manche"));
                manche1();
                break;
            case 2:
                print(PlayerPrefs.GetInt("Manche"));
                manche2();
                break;
            case 3:
                print(PlayerPrefs.GetInt("Manche"));
                manche3();
                break;
            case 4:
                print(PlayerPrefs.GetInt("Manche"));
                manche4();
                break;
            case 5:
                print(PlayerPrefs.GetInt("Manche"));
                manche5();
                break;
            case 6:
                print(PlayerPrefs.GetInt("Manche"));
                manche6();
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
