using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public GameObject panel;
    private int track;
    public void open()
    {
        if(panel!=null)
        {
            bool active = panel.activeSelf;
            panel.SetActive(!active);
            

        }
        

       

    }
}
