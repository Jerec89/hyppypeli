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

		// liikkuminen
		MoveAmount.x = MoveDirection * MoveSpeed * Time.deltaTime;
		transform.Translate (MoveAmount);
	
	}


	// suunnan ja spriten kääntäminen
	void OnTriggerEnter2D(Collider2D coll){
		if (facingRight) {
			MoveDirection = -1;
			Flip ();
		} else if (!facingRight) {
			MoveDirection = 1;
			Flip ();
		}
	}


	// spriten kääntämisen classi 
	void Flip ()
	{
		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}


}
