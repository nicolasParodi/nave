﻿using UnityEngine;
using System.Collections;

public class movenave : MonoBehaviour {

    private Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start () {

        myRigidbody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

        HandleMovement();

	}

    private void HandleMovement(){

        myRigidbody.velocity = Vector2.left;//x=-1,y=0,z=0;

    }
}
