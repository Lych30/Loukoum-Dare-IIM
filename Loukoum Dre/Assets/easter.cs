using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easter : MonoBehaviour
{
    public Camera camera;
 
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        camera.transform.position = new Vector3(-35.1f,0f, camera.transform.position.z);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        camera.transform.position = new Vector3(0f,0f, camera.transform.position.z);
    }
}
