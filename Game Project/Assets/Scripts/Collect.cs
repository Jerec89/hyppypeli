using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {

	// objektin keräys
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			Destroy(gameObject);
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
