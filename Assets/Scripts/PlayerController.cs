﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
       
    }
	

	// Update is called once per frame
	void Update () {
	
	}


    //before any phisics callculation
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movment = new Vector3(moveHorizontal, 0.0f, moveVertical);

       

        rb.AddForce(movment * speed);
    }
}