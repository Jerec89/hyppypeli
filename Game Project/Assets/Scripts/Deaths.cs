using UnityEngine;
using System.Collections;

public class Deaths : MonoBehaviour {

	
	TextMesh death;

	public static int deaths;

	// Use this for initialization
	void Start () {

		death = GetComponent <TextMesh> ();

		deaths = 0;
	}
	
	// Update is called once per frame
	void Update () {


		death.text = "Deaths: " + deaths;

		}


}
