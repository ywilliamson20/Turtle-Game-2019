using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buyer : MonoBehaviour
{
    private int score;
    private int price;
    public GameObject power;
    public GameObject play;
    private bool switchin =false;
    AudioSource ching;
    private int detect=0;
    // Start is called before the first frame update

    private void Start()
    {
        ching = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {

           // score = play.GetComponent<Player_Health_Segmented>().playerScore;
            Debug.Log("Power");
            Debug.Log(score);
            //power = GameObject.FindGameObjectWithTag("Projectile");
            //play = GameObject.FindGameObjectWithTag("Player");
            if (collision.GetComponent<Player_Health_Segmented>().playerScore > 350 && !switchin&& collision.GetComponent<Player_Health_Segmented>().playerScore < 550)
                {
                if (detect == 0)
                {
                    ching.Play();
                    detect++;
                }
                power.tag = "PowProjectile";
                    switchin = true;
                    //Debug.Log("Power changed");

                }
             else if (switchin && collision.GetComponent<Player_Health_Segmented>().playerScore > 550)
            {
                if (detect == 1)
                {
                    ching.Play();
                    detect++;
                }
                power.tag = "SuperProjectile";

               }

            else if (!switchin && collision.GetComponent<Player_Health_Segmented>().playerScore > 550)
            {
                if (detect == 0)
                {
                    ching.Play();
                    detect=2;
                }
                power.tag = "SuperProjectile";

            }
        }
            
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
