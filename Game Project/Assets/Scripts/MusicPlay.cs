using UnityEngine;
using System.Collections;

public class MusicPlay : MonoBehaviour {

	private AudioSource au;
	public AudioClip[] clips;
	
	private static MusicPlay instance = null;

	public static MusicPlay Instance {
		get {
			if (instance == null) {
				instance = (MusicPlay)FindObjectOfType (typeof(MusicPlay));
			}
			return instance;
		}
	}

	// Use this for initialization
	void Awake () {

		au = GetComponent<AudioSource>();
		au.clip = clips [0];
		au.Play ();

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

		if (Application.loadedLevelName == "MainMenu")
		{
			DestroyImmediate(gameObject);
		}

		if (Application.loadedLevelName == "Level2" && au.clip == clips[0]) {
			au.clip = clips[1];
			au.Play ();
		}

		else if (Application.loadedLevelName == "Level3" && au.clip == clips[1]) {
			au.clip = clips[2];
			au.Play ();
		}

		else if (Application.loadedLevelName == "Level4" && au.clip == clips[2]) {
			au.clip = clips[3];
			au.Play ();
		}
	}
}
