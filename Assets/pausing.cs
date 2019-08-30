using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pausing : MonoBehaviour
{
    public Text pauword;
    bool paused = false;
    string Pause = "PAUSED";
    public GameObject panel;

    public void pause()
    {
        if (paused)
        {
            Time.timeScale = 1;
            paused = false;
            panel.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            paused = true;
            panel.SetActive(true);
        }
    }
}
