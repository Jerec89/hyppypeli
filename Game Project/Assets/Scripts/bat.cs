﻿using UnityEngine;
using System.Collections;

public class bat : MonoBehaviour {

	private PlayerControl thePlayer;

	public float speed;

	public float range;

	public LayerMask playerLayer;

	public bool inRange = false;

	Vector3 startPos;

	private Animator anim;


	// Use this for initialization
	void Start () {

		thePlayer = FindObjectOfType<PlayerControl> ();
		startPos = transform.position;
		anim = GetComponent<Animator>();


	
	}
	
	// Update is called once per frame
	void Update () {

		inRange = Physics2D.OverlapCircle (transform.position, range, playerLayer);

		if (inRange) {
			
			transform.position = Vector3.MoveTowards (transform.position, thePlayer.transform.position, speed * Time.deltaTime);
			anim.SetBool ("move", true);
			if(transform.position.x - thePlayer.transform.position.x > 0){
				
				transform.localScale = new Vector2(2f,2f);
			}else
				transform.localScale = new Vector2(-2f,2f);
		


		} else if (!inRange) {
			transform.position = Vector3.MoveTowards (transform.position, startPos, speed * Time.deltaTime);

			if(transform.position.x - startPos.x > 0){
				
				transform.localScale = new Vector2(2f,2f);
			}else
				transform.localScale = new Vector2(-2f,2f);


			if (transform.position == startPos) {
				anim.SetBool ("move", false);
			}

		}
	}

	void OnDrawGizmosSelected(){

		Gizmos.DrawSphere (transform.position, range);

	}
		
}
