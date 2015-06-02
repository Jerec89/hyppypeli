using UnityEngine;
using System.Collections;

public class Objective : MonoBehaviour {

	public int scoreValue = 50;

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player1") {
			Destroy (gameObject);
			ScoreCont.score += scoreValue;
			Destroy(GameObject.Find("Door"));
			Destroy(GameObject.FindWithTag("Door1"));
			Destroy(GameObject.FindGameObjectWithTag("Door2"));
			
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
