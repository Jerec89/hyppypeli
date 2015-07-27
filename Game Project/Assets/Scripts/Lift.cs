using UnityEngine;
using System.Collections;

public class Lift : MonoBehaviour {

	public float MoveSpeed;
	public Vector2 MoveAmount;
	private float MoveDirection = 1.0f;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		MoveAmount.y = MoveDirection * MoveSpeed * Time.deltaTime;
		transform.Translate (MoveAmount);

	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Down") {
			MoveDirection = -1;

		} else if (coll.gameObject.tag == "Up") {
			MoveDirection = 1;
		}
	}
	
}
