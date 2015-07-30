using UnityEngine;
using System.Collections;

public class Cheats : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.Alpha1)){

			Application.LoadLevel("level1");
		}

		else if(Input.GetKey(KeyCode.Alpha2)){
			
			Application.LoadLevel("level2");
		}

		else if(Input.GetKey(KeyCode.Alpha3)){
			
			Application.LoadLevel("level3");
		}

		else if(Input.GetKey(KeyCode.Alpha4)){
			
			Application.LoadLevel("level4");
		}


		if (Input.GetKey (KeyCode.G)) {
			Physics2D.IgnoreLayerCollision(8,11,true);
		}
		
		if (Input.GetKey (KeyCode.M) ) {
			Physics2D.IgnoreLayerCollision(8,11,false);
		}
	}
}
