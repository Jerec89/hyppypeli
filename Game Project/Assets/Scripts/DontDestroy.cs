using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {
	

	private static DontDestroy instance = null;
	
	public static DontDestroy Instance {
		get {
			if (instance == null) {
				instance = (DontDestroy)FindObjectOfType (typeof(DontDestroy));
			}
			return instance;
		}
	}

	// Use this for initialization
	void Awake () {

		if (Instance != this || Application.loadedLevelName == "MainMenu")
		{
			Destroy(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
		}
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
