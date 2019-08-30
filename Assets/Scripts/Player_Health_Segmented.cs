using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health_Segmented : MonoBehaviour {
    // InstaDeath objects should be tagged "Death" and set as a trigger
    // Enemies (and other 1-damage obstacles) should be tagged "Enemy" and should NOT be set as a trigger

    private GameObject respawn;

    public int playerScore;
   

    [Tooltip("The score value of a coin or pickup.")]
    public int coinValue = 5;
    public int coinValue1 = 25;
    public int coinValue2 = 55;
    public int coinValue3 = 105;
    public int coinValue4 = 175;
    public int coinValueSpecial = 500;
    [Tooltip("The amount of points a player loses on death.")]
    public int deathPenalty = 20;
    public GameObject bound;
    public Text scoreText;
    // Feel free to add more! You'll need to edit the script in a few spots, though.
    public GameObject health3;
    public GameObject health2;
    public GameObject health1;
    public AudioSource source;
    public AudioSource gotit;






    // Use this for initialization
    void Start()
    {
        respawn = GameObject.FindGameObjectWithTag("Respawn");
        playerScore = 0;
        scoreText.text = playerScore.ToString("D4");

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Death"))
        {
            Respawn();
        }
        else if (collision.CompareTag("Coin"))
        {
            gotit.Play();
            AddPoints(coinValue);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Coin1"))
        {
            gotit.Play();
            AddPoints(coinValue1);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Coin2"))
        {
            gotit.Play();
            AddPoints(coinValue2);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Coin3"))
        {
            gotit.Play();
            AddPoints(coinValue3);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Coin4"))
        {
            gotit.Play();
            AddPoints(coinValue4);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("CoinSpecial"))
        {
            AddPoints(coinValueSpecial);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Finish"))
        {
            Time.timeScale = 0;
        }
        else if (collision.CompareTag("Health"))
        {
            AddHealth();
            Destroy(collision.gameObject);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            source.Play();
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        // For more health, copy the if block for health3, change health3 to whatever yours is,
        // then change the if statement for health3 to else if
        if (health3.activeInHierarchy)
        {
            health3.SetActive(false);
        }
        else if (health2.activeInHierarchy)
        {
            health2.SetActive(false);
        }
        else
        {
            health1.SetActive(false);
            Respawn();
        }
    }
     
    private void AddHealth()
    {
        if (!health2.activeInHierarchy)
        {
            health2.SetActive(true);
        }
        else if (!health3.activeInHierarchy)
        {
            health3.SetActive(true);
        }
        // For more health, just copy the else if block for health3 and change the name.
    }

    public void Respawn()
    {
        // For more health, just add another similar line here.
        health3.SetActive(true);
        health2.SetActive(true);
        health1.SetActive(true);
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        gameObject.transform.position = respawn.transform.position;
        AddPoints(deathPenalty);
    }

    public int GetScore()
    {
        return playerScore;
    }

    public void AddPoints(int amount)
    {
        playerScore += amount;
        scoreText.text = playerScore.ToString("D4");
        if(playerScore>729)
        {
            bound.SetActive(false);
        }
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("score", playerScore);
    }
}
