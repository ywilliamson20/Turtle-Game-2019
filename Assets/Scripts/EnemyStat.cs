using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyStat : MonoBehaviour
{
    public int startingHealth = 100;            // The amount of health the enemy starts the game with.
    public int attackDamage = 10;
    public int currentHealth;
    public GameObject power;
    public GameObject bounds;
    public GameObject boundss;

    //public int xpValue = 5;
    //public AudioSource source;
    //public AudioClip shot;
    //public AudioClip dead;

    GameObject player;
    private void Start()
    {
        //AudioSource[] sources = GetComponents<AudioSource>();
        //source = sources[0];
        //shot = sources[0].clip;
        //dead = sources[1].clip;
    }
   
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        currentHealth = startingHealth;
        power = GameObject.FindGameObjectWithTag("Projectile");

    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Projectile"&& power.tag == "Projectile"&& !boundss.activeSelf)
        {
            TakeDamage1(10);
        }
        else if (collision.tag == "Projectile" && power.tag == "PowProjectile" && !boundss.activeSelf)
        {
            TakeDamage1(30);
        }
        else if (collision.tag == "Projectile" && power.tag == "SuperProjectile" && !boundss.activeSelf)
        {
            TakeDamage1(60);
        }
    }


    public void TakeDamage1(int amount) {
       
        currentHealth -= amount;
        Debug.Log("Enemy health is: " + currentHealth);

        if (currentHealth > 0)
        {
            //source.PlayOneShot(shot);

        }
        if (currentHealth <= 0) {
            //source.PlayOneShot(dead);
            // ... the enemy is dead.
            Death();
        }
    }

    public void Death() {
        // The enemy is dead.
       gameObject.SetActive(false);
        bounds.SetActive(false);
       //Destroy(this.gameObject);
        
    }

    
}
