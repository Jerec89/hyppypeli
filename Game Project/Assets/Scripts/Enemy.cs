using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float MoveSpeed;
	public Vector2 MoveAmount;
	private float MoveDirection = 1.0f;

	bool facingRight = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		MoveAmount.x = MoveDirection * MoveSpeed * Time.deltaTime;
		transform.Translate (MoveAmount);
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Wall1") {
			MoveDirection = -1;
			Flip();
		} else if (coll.gameObject.tag == "Wall2"){
			MoveDirection = 1;
			Flip();
		}
	}

	void Flip ()
	{
		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}



}
