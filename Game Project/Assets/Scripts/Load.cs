using UnityEngine;
using System.Collections;

public class Load : MonoBehaviour {

	public static int MScore;
	public static int MDeaths;
	public static float MTime;

	// Use this for initialization
	void Start () {

		MTime = PlayerPrefs.GetFloat("CurrentPlayerTime");
		MDeaths = PlayerPrefs.GetInt ("CurrentPlayerDeaths");
		MScore =  PlayerPrefs.GetInt ("CurrentPlayerScore");
		StartCoroutine(Wait());
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator Wait() {
		
		yield return new WaitForSeconds (2);
		Application.LoadLevel ("MainMenu");
	}
}
