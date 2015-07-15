using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCont : MonoBehaviour {

	public static int score;

	Text Text;
	

	// Use this for initialization
	void Start () {

		Text = GetComponent <Text> ();

		score = PlayerPrefs.GetInt ("CurrentPlayerScore");
	}
	
	// Update is called once per frame
	void Update () {
		
		Text.text = "Score: " + score;
	}

	public static void AddPoints(int PointsToAdd)
	{
		score += PointsToAdd;
	}
	
	public static void Reset()
	{
		score = 0;
		PlayerPrefs.SetInt ("CurrentPlayerScore", score);

	}
}
