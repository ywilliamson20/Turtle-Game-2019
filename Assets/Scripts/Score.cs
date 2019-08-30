using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject panel;
    public GameObject panellose;
    private int track;
    [SerializeField] private Text scoreText;

   // private Text scoreText;
    private int coinCount=0;

    // Start is called before the first frame update
    void OnEnable()
    {
        coinCount= PlayerPrefs.GetInt("score");
    }

    void Start()
    {
        
      
    }

    public void open()
    {
    if (coinCount > 900)
    {
        if (panel != null)
        {
            bool active = panel.activeSelf;
            panel.SetActive(!active);


        }
    }
    else
    {
        if (panellose != null)
        {
            bool active = panellose.activeSelf;
            panellose.SetActive(!active);


        }

    }

    }
    
    //scoreText.text = "Final Score: " + coinCount.ToString();
    //scoreText.text = 
    //gameObject.GetComponent<Text>().font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;

    //gameObject.GetComponent<Text>().fontSize = 40;


}
