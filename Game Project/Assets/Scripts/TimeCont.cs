using UnityEngine;
using System.Collections;
using System.Diagnostics;
using UnityEngine.UI;

public class TimeCont : MonoBehaviour {

	Text TimeText;

	float timer = 0f;
	string min;
	string sec;

	// Use this for initialization
	void Start () {

		TimeText = GetComponent <Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		min = Mathf.Floor(timer / 60).ToString("00");
		sec = (timer % 60).ToString("00");

		TimeText.text = "Time: " + min + ":" + sec;
	
	}
}
