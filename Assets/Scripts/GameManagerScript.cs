using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{

    public void restart()
    {        
        SceneManager.LoadScene("InGame", LoadSceneMode.Single);

    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
