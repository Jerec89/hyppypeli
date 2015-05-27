using UnityEngine;
using System.Collections;


public class PlayerControl : MonoBehaviour {
	
    bool facingRight = true;
    bool jump = false;

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



		if (rb2d.velocity.y > 0.0f) {
			Physics2D.IgnoreLayerCollision (8, 9, true);
		} else {
			Physics2D.IgnoreLayerCollision(8, 9, false);
		}

		if (Input.GetButtonDown ("Jump")) {
			if (hyppy) {
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

			if (h * rb2d.velocity.x < maxSpeed) {

			rb2d.AddForce (Vector2.right * h * moveForce);

		}
			if (Mathf.Abs (rb2d.velocity.x) > maxSpeed) {

			rb2d.velocity = new Vector2 (Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);
		}

		if (h > 0 && !facingRight) {
			Flip ();
		} else if (h < 0 && facingRight) {
			Flip ();
		}

			if (jump)
			{
				rb2d.AddForce(new Vector2(0f, jumpForce));
				jump = false;
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
