using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public Canvas PauseMenu;

	// Use this for initialization
	void Start () {

		PauseMenu = PauseMenu.GetComponent<Canvas> ();

		PauseMenu.enabled = false;
	
	}

	public void ContinuePress()
	{
		PauseMenu.enabled = false;
		Time.timeScale = 1.0f;


	}

	public void ExitPress()
	{	
		Application.LoadLevel ("MainMenu");
		Time.timeScale = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Escape)) {
			PauseMenu.enabled = true;
			Time.timeScale = 0.0f;

		}
	
	}
}
