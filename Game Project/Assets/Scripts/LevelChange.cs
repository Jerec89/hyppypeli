﻿using UnityEngine;
using System.Collections;

public class LevelChange : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level1") {
			Application.LoadLevel ("Level1a");
			
		} else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level1") {
			Application.LoadLevel ("Level1b");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level1a") {
			Application.LoadLevel ("Level1a2");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level1a") {
			Application.LoadLevel ("Level1b2");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level1b") {
			Application.LoadLevel ("Level1a2");
		}
		
		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level1b") {
			Application.LoadLevel ("Level1b2");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level1a2") {
			Application.LoadLevel ("Level1a3");
		}
		
		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level1a2") {
			Application.LoadLevel ("test_Map");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level1b2") {
			Application.LoadLevel ("Level1a3");
		}
		
		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level1b2") {
			Application.LoadLevel ("test_Map");
		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}