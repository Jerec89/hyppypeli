using UnityEngine;
using System.Collections;


public class PlayerControl : MonoBehaviour {
	
    bool facingRight = true;
    bool jump = false;

	int deathVal = 1;
	float speed = 100;
	public float moveForce;
	public float maxSpeed;
	public float jumpForce;
	
	private Animator anim;
	private Rigidbody2D rb;
	bool hyppy = true;

	Vector3 start;


	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();

		start = transform.position;

	
	}
	
	

	// Update is called once per frame
	void Update () {
	
		// Platformin läpi hyppiminen
		if (rb.velocity.y > 0.0f) {
			Physics2D.IgnoreLayerCollision (8, 9, true);
		} else {
			Physics2D.IgnoreLayerCollision(8, 9, false);
		}

		// Hyppiminen
		if (Input.GetButtonDown ("Jump")) {
			if (hyppy) {
				jump = true;
				hyppy = false;
				GetComponent<AudioSource>().Play();


			}
		}

		
	}

	// kerta hyppy
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "enemy") {

			Deaths.deaths += deathVal;
			transform.position = Vector3.MoveTowards(transform.position, start, speed);
		}
		if (other.collider.tag == "Ground") {

			hyppy = true;
		}

		if (other.gameObject.tag == "Score"){
	
		}

	}

	void FixedUpdate(){

		// Liikkuminen
			float h = Input.GetAxis("Horizontal");

			anim.SetFloat("Speed", Mathf.Abs(h));

			if (h * rb.velocity.x < maxSpeed) {

			rb.AddForce (Vector2.right * h * moveForce);

		}
			if (Mathf.Abs (rb.velocity.x) > maxSpeed) {

			rb.velocity = new Vector2 (Mathf.Sign (rb.velocity.x) * maxSpeed, rb.velocity.y);
		}

		// spriten käätäminen
		if (h > 0 && !facingRight) {
			Flip ();
		} else if (h < 0 && facingRight) {
			Flip ();
		}

		// hyppy voima
			if (jump)
			{
				rb.AddForce(new Vector2(0f, jumpForce));
				jump = false;
			}


		}

	// Spriten kääntäminen classi
	void Flip ()
	{
		facingRight = !facingRight;
		
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	

}
