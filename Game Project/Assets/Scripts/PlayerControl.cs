using UnityEngine;
using System.Collections;



public class PlayerControl : MonoBehaviour {
	
    bool facingRight = true;
    bool jump = false;

	private int deathVal = 1;
	public float moveForce;
	public float maxSpeed;
	public float jumpForce;

	public GameObject LArrow;
	public GameObject RArrow;
	public GameObject DArrow;
	
	private Animator anim;
	private Rigidbody2D rb;
	private AudioSource au;

	bool hyppy = true;
	bool isFalling;
	

	public AudioClip[] clips;


	void Start () 
	{


		au = GetComponent<AudioSource>();
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();


	
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

				anim.SetBool("IsJumping",true);
				anim.SetBool("IsGround",false);
				jump = true;
				hyppy = false;
				au.PlayOneShot(clips[0]);
			}
		}

		
	}

	// kerta hyppy
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "enemy") {

			GameObject deathpart = (GameObject)Instantiate(Resources.Load("DeathPart"),transform.position,transform.rotation);
			Application.LoadLevel(Application.loadedLevel);
			Deaths.AddDeaths(deathVal);

		}
		if (other.collider.tag == "Ground") {

			hyppy = true;
			anim.SetBool("IsJumping",false);
			anim.SetBool("IsGround",true);
		}



	}
	void OnTriggerEnter2D(Collider2D coll){

		if (coll.gameObject.tag == "Score"){
			au.PlayOneShot(clips[1]);
			
		}
		
		if (coll.gameObject.tag == "obj"){
			au.PlayOneShot(clips[2]);
			LArrow.SetActive(true);
			RArrow.SetActive(true);
			
		}

		if (coll.gameObject.tag == "F_obj"){
			au.PlayOneShot(clips[2]);
			DArrow.SetActive(true);
			
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
