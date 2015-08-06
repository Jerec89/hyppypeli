using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainTime : MonoBehaviour {

	Text Text;

	string min;
	string sec;

	// Use this for initialization
	void Start () {
		Text = GetComponent <Text> ();

		min = Mathf.Floor(Load.MTime / 60).ToString("00");
		sec = (Load.MTime % 60).ToString("00");
		
		Text.text = "" + min + ":" + sec;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
