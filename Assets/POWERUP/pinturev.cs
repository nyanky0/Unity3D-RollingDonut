using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinturev : MonoBehaviour {

    public GameObject pintu;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject)
        {
            Time.timeScale = 0f;
            pintu.SetActive(true);
        }


    }
}
