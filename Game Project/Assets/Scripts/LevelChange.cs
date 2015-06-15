using UnityEngine;
using System.Collections;

public class LevelChange : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll){

		//Level 1

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
			Application.LoadLevel ("Level1b2");
		}
		
		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level1b") {
			Application.LoadLevel ("Level1a2");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level1a2") {
			Application.LoadLevel ("Level1a3");
		}
		
		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level1a2") {
			Application.LoadLevel ("Level1b3");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level1b2") {
			Application.LoadLevel ("Level1b3");
		}
		
		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level1b2") {
			Application.LoadLevel ("Level1a3");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelC" && (Application.loadedLevelName == "Level1a3" || Application.loadedLevelName == "Level1b3") ) {
			Application.LoadLevel ("Level2");
		}




		//Level 2

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level2") {
			Application.LoadLevel ("Level2a");
		}
		
		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level2") {
			Application.LoadLevel ("Level2b");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level2a") {
			Application.LoadLevel ("Level2a2");
		}
		
		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level2a") {
			Application.LoadLevel ("Level2b2");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level2b") {
			Application.LoadLevel ("Level2b2");
		}
		
		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level2b") {
			Application.LoadLevel ("Level2a2");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level2a2") {
			Application.LoadLevel ("Level2a3");
		}
		
		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level2a2") {
			Application.LoadLevel ("Level2b3");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level2b2") {
			Application.LoadLevel ("Level2b3");
		}
		
		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level2b2") {
			Application.LoadLevel ("Level2a3");
		}

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelC" && (Application.loadedLevelName == "Level2a3" || Application.loadedLevelName == "Level2b3") ) {
			Application.LoadLevel ("Level3");
		}



		//Level 3

		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelA" && Application.loadedLevelName == "Level3") {
			Application.LoadLevel ("MainMenu");
		}
		
		else if (coll.gameObject.tag == "Player1" && gameObject.tag == "levelB" && Application.loadedLevelName == "Level3") {
			Application.LoadLevel ("MainMenu");
		}


	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
