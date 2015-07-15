using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeCont : MonoBehaviour {

	Text TimeText;

	float timer;
	string min;
	string sec;

	// Use this for initialization
	void Start () {

		TimeText = GetComponent <Text> ();
		timer = PlayerPrefs.GetFloat("CurrentPlayerTime");
	}
	
	// Update is called once per frame
	 void Update () {

		timer += Time.deltaTime;
		PlayerPrefs.SetFloat("CurrentPlayerTime",timer);
		min = Mathf.Floor(timer / 60).ToString("00");
		sec = (timer % 60).ToString("00");

		TimeText.text = "Time: " + min + ":" + sec;
	
	}
}
