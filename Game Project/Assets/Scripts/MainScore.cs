using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainScore : MonoBehaviour {

	Text Text;

	// Use this for initialization
	void Start () {
		Text = GetComponent <Text> ();
		Text.text = "" + Load.MScore;
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
