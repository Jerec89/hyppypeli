using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public Camera Maincamera;
	public Camera Camera2;

	void OnMouseEnter(){
		
		GetComponent<Renderer>().material.color = Color.green;
		
	}

	void OnMouseExit(){
		
		GetComponent<Renderer>().material.color = Color.white;
		
	}

	void OnMouseDown(){
		
		if (this.name == "MapText") {
			Application.LoadLevel ("test_Map");
			
		} 

		else if(this.name == "Controls"){

			Maincamera.GetComponent<Camera>().enabled = false;
			Camera2.GetComponent<Camera>().enabled = true;
			
		}

		else if(this.name == "Return"){
			Maincamera.GetComponent<Camera>().enabled = true;
			Camera2.GetComponent<Camera>().enabled = false;
			
		}
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
