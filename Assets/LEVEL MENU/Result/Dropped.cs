using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropped : MonoBehaviour {

    public GameObject paneldrop;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject)
        {
            Time.timeScale = 0f;
            paneldrop.SetActive(true);
        }


    }
}
