using UnityEngine;
using System.Collections;


public class PlayerControl : MonoBehaviour {
	
	[HideInInspector] public bool facingRight = true;
	[HideInInspector] public bool jump = false;
	public float moveForce;
	public float maxSpeed;
	public float jumpForce;
	
	private Rigidbody2D rb2d;
	bool hyppy = true;
	void Awake () 
	{
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	

	// Update is called once per frame
	void Update () {



		if (Input.GetButtonDown ("Jump")) {
			if(hyppy){
			jump = true;
				hyppy = false;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.collider.tag == "Ground") {

			hyppy = true;
		}

	}

	void FixedUpdate(){

			float h = Input.GetAxis("Horizontal");
			
			if (h * rb2d.velocity.x < maxSpeed)
				rb2d.AddForce(Vector2.right * h * moveForce);
			
			if (Mathf.Abs (rb2d.velocity.x) > maxSpeed)
				rb2d.velocity = new Vector2(Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);
			
			
			if (jump)
			{
				rb2d.AddForce(new Vector2(0f, jumpForce));
				jump = false;
			}
		}

		 
	
}
