using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_start : MonoBehaviour
{
    public void Game()
    {
        //The scene number to load (in File->Build Settings)
        SceneManager.LoadScene("Turtie_L1");
    }

    public void Main()
    {
        //The scene number to load (in File->Build Settings)
        SceneManager.LoadScene("Main Menu");
    }

    public void End()
    {
        //The scene number to load (in File->Build Settings)
        SceneManager.LoadScene("End");
    }


}
