using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour{

    public Transform destination;
    public GameObject objManche1, objManche2, objManche3, objManche4, objManche5, lazer1, lazer2, lazer3, lazer4;
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
        objManche1.SetActive(true);
    }
    void manche2()
    {
        manche1();
        print("obj manche2");
        objManche2.SetActive(true);
        lazer1.SetActive(true);
    }
    void manche3()
    {
        manche1();
        manche2();
        print("obj manche3");
        objManche3.SetActive(true);
        lazer2.SetActive(true);
    }
    void manche4()
    {
        manche1(); 
        manche2(); 
        manche3();
        objManche4.SetActive(true);
        print("obj manche4");
        lazer3.SetActive(true);
        lazer4.SetActive(true);
    }
    void manche5()
    {
        manche1();
        manche2();
        manche3();
        manche4();
        objManche5.SetActive(true);
        lazer1.SetActive(false);
        lazer2.SetActive(false);
        lazer3.SetActive(false);
        lazer4.SetActive(false);

        print("obj manche5");
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
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            collision.transform.position = destination.position;
            PlayerPrefs.SetInt("Manche", PlayerPrefs.GetInt("Manche")+1);
            NewLevel(PlayerPrefs.GetInt("Manche"));
            if(PlayerPrefs.GetInt("Manche",1) >= 6)
            {
                SceneManager.LoadScene("Menu");
                print("vous avez gagné");
            }
        }
    }

}
