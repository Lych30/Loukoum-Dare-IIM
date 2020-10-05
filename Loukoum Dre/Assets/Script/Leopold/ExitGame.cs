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
        PlayerPrefs.SetInt("Manche", 1);
        SceneManager.LoadScene("Game");
    }
   public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
