using UnityEngine;
using System.Collections;

public class MusicPlay2 : MonoBehaviour {

	// Use this for initialization
	void Start () {


			DontDestroyOnLoad (transform.gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Application.loadedLevelName == "Level3") {
			
			DestroyImmediate(gameObject);
			
		} 

	}
}
