using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    private GameObject Bird;

    private float pX;


    private Vector2 currentVelocity;
    public float smoothX;
    public float smoothY;


    void Awake()
    {
        Bird = GameObject.FindGameObjectWithTag("Bird");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Bird == null)
        {
            Bird = GameObject.FindGameObjectWithTag("Bird");
        }
        else
        {
            SmoothCamera();
        }
    }


    void SmoothCamera()
    {
        pX = Mathf.SmoothDamp(transform.position.x, Bird.transform.position.x, ref currentVelocity.x, smoothX);
       
        transform.position = new Vector3(pX, transform.position.y, transform.position.z);
    }
}




