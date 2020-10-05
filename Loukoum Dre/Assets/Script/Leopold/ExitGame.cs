using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    public void ClickExit()
    {
        Application.Quit();
    }
    public void LauchGame()
    {
        SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
    }
    

}
