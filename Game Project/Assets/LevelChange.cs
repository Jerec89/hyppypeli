using UnityEngine;
using System.Collections;

public class LevelChange : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player1") {
			Application.LoadLevel("test_Map");
			
		}
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
