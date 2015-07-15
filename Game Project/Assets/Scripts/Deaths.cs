using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Deaths : MonoBehaviour {

	
	Text death;

	public static int deaths;

	// Use this for initialization
	void Start () {

		death = GetComponent <Text> ();

		deaths = PlayerPrefs.GetInt ("CurrentPlayerDeaths");
	}
	
	// Update is called once per frame
	void Update () {


		death.text = "Deaths: " + deaths;

		}

	public static void AddDeaths(int DeathsToAdd)
	{
		deaths += DeathsToAdd;
		PlayerPrefs.SetInt ("CurrentPlayerDeaths", deaths);
	}
	
	public static void Reset()
	{
		deaths = 0;
		PlayerPrefs.SetInt ("CurrentPlayerDeaths", deaths);
		
	}

}
