using UnityEngine;
using System.Collections;

public class Cheats : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.Alpha1)){

			Application.LoadLevel("level2a");
		}

		else if(Input.GetKey(KeyCode.Alpha2)){
			
			Application.LoadLevel("level2a2");
		}

		else if(Input.GetKey(KeyCode.Alpha3)){
			
			Application.LoadLevel("level2a3");
		}

		else if(Input.GetKey(KeyCode.Alpha4)){
			
			Application.LoadLevel("level2b");
		}

		else if(Input.GetKey(KeyCode.Alpha5)){
			
			Application.LoadLevel("level2b2");
		}

		else if(Input.GetKey(KeyCode.Alpha6)){
			
			Application.LoadLevel("level2b3");
		}

	}
}
