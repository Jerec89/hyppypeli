using UnityEngine;
using System.Collections;

public class PlayMusic3 : MonoBehaviour {

	// Use this for initialization
	void Start () {

		DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {

		if (Application.loadedLevelName == "Level4") {
			
			DestroyImmediate(gameObject);
			
		} 
	
	}
}
