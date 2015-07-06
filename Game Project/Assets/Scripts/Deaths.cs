using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Deaths : MonoBehaviour {

	
	Text death;

	public static int deaths;

	// Use this for initialization
	void Start () {

		death = GetComponent <Text> ();

		deaths = 0;
	}
	
	// Update is called once per frame
	void Update () {


		death.text = "Deaths: " + deaths;

		}


}
