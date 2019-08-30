using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_bounds : MonoBehaviour
{
    public GameObject bounds;
    public GameObject bounds2;
    public GameObject bounds3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        
       
            Debug.Log("got here");
            bounds.SetActive(false);
            bounds2.SetActive(false);
            bounds3.SetActive(false);
        
    }
}
