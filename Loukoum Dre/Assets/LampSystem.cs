using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampSystem : MonoBehaviour
{



    public GameObject[] lampEntities;
    void Start()
    {
        lampEntities = GameObject.FindGameObjectsWithTag("Lamp");
        print(lampEntities.Length);
        //gos = GameObject.FindGameObjectsWithTag("Enemy");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
