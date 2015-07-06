using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCont : MonoBehaviour {

	public static int score;

	Text Text;
	

	// Use this for initialization
	void Start () {

		Text = GetComponent <Text> ();

		score = 0;


	}
	
	// Update is called once per frame
	void Update () {
	
		Text.text = "Score: " + score;

	}
}
