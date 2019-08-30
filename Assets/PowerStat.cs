using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerStat : MonoBehaviour
{

    [SerializeField] private Text scoreText;
    public string power;
    public GameObject powup;

    void Start()
    {

        //powup= GameObject.FindGameObjectWithTag("Projectile");
       
       


    }

    void Update()
    {
        if(powup.tag=="Projectile")
        {
            scoreText.text = "Currently Have: Basic Power";

        }
        else if (powup.tag == "PowProjectile")
        {
            scoreText.text = "Currently Have: Powerful Power";

        }
        else if (powup.tag == "SuperProjectile")
        {
            scoreText.text = "Currently Have: Super Power";

        }
        // scoreText.text = "Currently Have: " + powup.tag.ToString();
    }

}
