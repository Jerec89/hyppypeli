using UnityEngine;
using System.Collections;

public class MusicPlay : MonoBehaviour {

	// Use this for initialization
	void Awake () {

		DontDestroyOnLoad (transform.gameObject);

	}
	
	// Update is called once per frame
	void Update () {
	

		if (Application.loadedLevelName == "Level2") {
			
			DestroyImmediate(gameObject);
			
		} 
	}
}
