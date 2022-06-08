using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class KubusGerak : MonoBehaviour {

    public float speed = 5f;
    public float jump = 7f;
    public float speedk = 20f;
    public Vector2 jumpHeight;
    public Vector2 jumpPower;
    public Vector2 revPower;
    public Vector2 boostPower;
    public Vector2 downPower;
    public Rigidbody2D rigid;
    private bool loncat;
    public AudioClip audioBoost;
    public AudioClip audioJump;
    public AudioClip Backsound;

    public bool tanah;
	public LayerMask targetlayer;
	public Transform deteksitanah;
	public float jangkauan;

    public AudioSource fxSound;

    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
        AudioSource.PlayClipAtPoint(Backsound, transform.position);
    }
	
	// Update is called once per frame
	void Update () {
        
		tanah = Physics2D.OverlapCircle (deteksitanah.position, jangkauan, targetlayer);
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (tanah == true && (Input.GetMouseButtonDown(0)))
        {
			
				GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
            
			
            //GameObject.Rigidbody.AddForce(Vector3.up * jumpForce);
            //transform.Translate(Vector2.up * jump * Time.deltaTime);
            
        }

        /*if (!loncat)
        {
            loncat = Input.GetKeyDown(KeyCode.Space);
            Debug.Log("Loncat");
        }*/
        
   }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "PJump")
        {
            GetComponent<Rigidbody2D>().AddForce(jumpPower, ForceMode2D.Impulse);
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(audioJump, transform.position);
        }
        if (other.transform.tag == "PRev")
        {
            GetComponent<Rigidbody2D>().AddForce(revPower, ForceMode2D.Impulse);
            Destroy(other.gameObject);
        }
        if (other.transform.tag == "Pintu")
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (other.transform.tag == "PBoost")
        {
            GetComponent<Rigidbody2D>().AddForce(boostPower, ForceMode2D.Impulse);
            AudioSource.PlayClipAtPoint(audioBoost, transform.position);
        }
        if (other.transform.tag == "PRem")
        {

            Destroy(other.gameObject);
        }
        if (other.transform.tag == "PDown")
        {
            GetComponent<Rigidbody2D>().AddForce(downPower, ForceMode2D.Impulse);
            Destroy(other.gameObject);
        }
    }
}
    