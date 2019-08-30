using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colli_disappear : MonoBehaviour
{
    public GameObject enemy;
    public GameObject bounds;

   
    void Update()
    {
        if(enemy.activeInHierarchy == false)
        {
            Debug.Log("got here");
            bounds.SetActive(false);

        }
    }
}
