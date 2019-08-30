using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    
    [SerializeField] private float lifeTime = 2.0f;
    private int lifeTimeFrames = 0;
    private int timeLived = 0;


    [SerializeField] private float relativeVelocity = 1f;
    private float velocity = 0f;


	void Start () {
        
        lifeTimeFrames = (int)(lifeTime / Time.fixedDeltaTime);
	}
	
    public void Launch(float emitVelocity, int going)
    {
        if (going==0)
        {
            velocity = emitVelocity + relativeVelocity;
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * velocity;
        }
        else if(going==1)
        {
            velocity = emitVelocity - relativeVelocity;
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * velocity;
        }
        else if (going == 2)
        {
            velocity = emitVelocity + relativeVelocity;
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * velocity;
        }
        
    }
	void FixedUpdate () {
		if (timeLived < lifeTimeFrames)
        {
            timeLived++;
        }
        else
        {
            Destroy(gameObject);
        }
	}
}
