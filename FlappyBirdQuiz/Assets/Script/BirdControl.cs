using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdControl : MonoBehaviour {

    Rigidbody2D rb;
    public float flapForce = 6f;
    public Text gameover;
    public int Points;
    public Text pointsText;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        Points = 0;
        pointsText.text = "SCORE :" + Points.ToString();
        gameover.text = "";

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)){

            rb.velocity = new Vector2(5, flapForce);
            Points = Points + 1;
        }

	}

    void OnTriggerEnter2D(Collider hit)
    {
        if (hit.gameObject.CompareTag ("Score"))
        {
            Points++;

            pointsText.text = "SCORE :" + Points.ToString();



        }
    }
    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.CompareTag ("Ground") || hit.gameObject.CompareTag ("Obs"))
        {
            gameover.text = "GAME OVER";
        }

    }
}
