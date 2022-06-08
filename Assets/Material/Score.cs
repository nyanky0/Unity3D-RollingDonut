using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    float detik;
    public float timme = 0.5f;
    public float rptime = 0.13f;
    public Text ScoreLabel;
    private int skor = 0;

    private void Start()
    {
        InvokeRepeating("Skor", timme, rptime);
        ScoreLabel.text = skor.ToString();
    }
    private void Update()
    {
        detik += Time.deltaTime;
    }
    void Skor()
    {
       
            skor = skor + 1;
            ScoreLabel.text = skor.ToString();
        
    }

    /*private int now = 3;
    private int skor = 0;
    public Text ScoreLabel;

    private void Start()
    {
        ScoreLabel.text = skor.ToString();
    }
    void Update () {
        InvokeRepeating("AddScore", 1, 150000);
		
	}
    void AddScore()
    {
        if (now > 0)
        {
            skor = skor + 1;
            ScoreLabel.text = skor.ToString();
        }
    }*/
}
