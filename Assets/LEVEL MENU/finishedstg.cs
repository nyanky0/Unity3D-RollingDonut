using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishedstg : MonoBehaviour
{
    public GameObject panel;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject)
         {
            panel.SetActive(true);
        }

    
    }
}
