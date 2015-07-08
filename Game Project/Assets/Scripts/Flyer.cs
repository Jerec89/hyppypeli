using UnityEngine;
using System.Collections;

public class Flyer : MonoBehaviour {

	private PlayerControl thePlayer;

	public float speed;

	float Back = 100;

	public float range;

	public LayerMask playerLayer;

	public bool inRange = false;

	Vector3 startPos;


	// Use this for initialization
	void Start () {

		thePlayer = FindObjectOfType<PlayerControl> ();
		startPos = transform.position;

	
	}
	
	// Update is called once per frame
	void Update () {

		inRange = Physics2D.OverlapCircle (transform.position, range, playerLayer);

		if (inRange) {

			transform.position = Vector3.MoveTowards (transform.position, thePlayer.transform.position, speed * Time.deltaTime);
		


		} else if (!inRange) {
			transform.position = Vector3.MoveTowards(transform.position, startPos, speed * Time.deltaTime);
		}
	}

	void OnDrawGizmosSelected(){

		Gizmos.DrawSphere (transform.position, range);

	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "Player1") {
		
			transform.position = Vector3.MoveTowards(transform.position,startPos, Back);
		}
	}
	
}
