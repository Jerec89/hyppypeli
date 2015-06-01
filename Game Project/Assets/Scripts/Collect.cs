using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {
	
	public int scoreValue = 10;

	// objektin keräys
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player1") {
			Destroy (gameObject);
			ScoreCont.score += scoreValue;

		}
	}


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}

}