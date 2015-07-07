﻿using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevelName == "MainMenu") {
			
			DestroyImmediate (gameObject);
	
		}
	}
}
