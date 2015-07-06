using UnityEngine;
using System.Collections;
using System.Diagnostics;
using UnityEngine.UI;

public class TimeCont : MonoBehaviour {

	Text TimeText;

	Stopwatch stopwatch = new Stopwatch();

	// Use this for initialization
	void Start () {

		TimeText = GetComponent <Text> ();
	
		stopwatch.Start();
	}
	
	// Update is called once per frame
	void Update () {

		TimeText.text = "Time: " + stopwatch.Elapsed.Minutes + " min " + stopwatch.Elapsed.Seconds + " s";
	
	}
}
