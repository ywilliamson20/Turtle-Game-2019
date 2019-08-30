using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour {


    [SerializeField] private GameObject projectile;
    private int facingRight = 0;
    [SerializeField] private int MaxActiveShots;
    private Rigidbody2D rbdPlayer;
    AudioSource source;
    //AudioClip clip;
    
    // Use this for initialization
    void Start()
    {
        rbdPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (facingRight)
        //{//
          if (Input.GetAxis("Horizontal") < 0)
            {
                transform.RotateAround(rbdPlayer.transform.position, Vector3.up, 90f);
                facingRight = 1;
         // }
        }else if (Input.GetAxis("Horizontal") > 0)
        {
            transform.RotateAround(rbdPlayer.transform.position, Vector3.up, 90f);
            facingRight = 0;
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            transform.RotateAround(rbdPlayer.transform.position, Vector3.up, 90f);
            facingRight = 2;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            source.Play();
            if (GameObject.FindGameObjectsWithTag("Attack").Length < MaxActiveShots)
            {
                GameObject shot = Instantiate(projectile);
                shot.transform.position = this.transform.position;
                shot.SetActive(true);
                float playerSpeed = rbdPlayer.velocity.x;
                shot.GetComponent<Projectile>().Launch(playerSpeed, facingRight);
            }
        }

    }
}
