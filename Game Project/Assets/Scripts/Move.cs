﻿using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed = 5;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = transform.up * speed;
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
