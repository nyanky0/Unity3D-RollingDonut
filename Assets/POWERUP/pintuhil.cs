using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pintuhil : MonoBehaviour {

    public GameObject hilangkan;
    public GameObject hilangkan1;
    public GameObject hilangkan2;
    public GameObject hilangkan3;
    public GameObject hilangkan4;
    public GameObject hilangkan5;
    public GameObject danMunculkan;
    public Rigidbody2D chara;
    public Vector2 speed;
    private void Start()
    
    {
        chara = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject)
        {
            Time.timeScale = 0f;
            hilangkan.SetActive(false);
            hilangkan1.SetActive(false);
            hilangkan2.SetActive(false);
            hilangkan3.SetActive(false);
            hilangkan4.SetActive(false);
            hilangkan5.SetActive(false);
            danMunculkan.SetActive(true);
        }


    }
}
