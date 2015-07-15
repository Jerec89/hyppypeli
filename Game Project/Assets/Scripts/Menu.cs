using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public Canvas HelpMenu;
	public Canvas CreditsMenu;
	public Button PlayText;
	public Button HelpText;
	public Button QuitText;
	public Button CreditsText;

	// Use this for initialization
	void Start () {
	
		HelpMenu = HelpMenu.GetComponent<Canvas> ();
		CreditsMenu = CreditsMenu.GetComponent<Canvas> ();
		PlayText = PlayText.GetComponent<Button> ();
		HelpText = HelpText.GetComponent<Button> ();
		QuitText = QuitText.GetComponent<Button> ();
		CreditsText = CreditsText.GetComponent<Button> ();
		HelpMenu.enabled = false;
		CreditsMenu.enabled = false;

	}

	public void HelpPress()
	{
		HelpMenu.enabled = true;
		PlayText.enabled = false;
		QuitText.enabled = false;
		CreditsText.enabled = false;
	}

	public void ClosePress()
	{
		HelpMenu.enabled = false;
		PlayText.enabled = true;
		QuitText.enabled = true;
		CreditsText.enabled = true;
	}

	public void ClosePress1()
	{
		CreditsMenu.enabled = false;
		PlayText.enabled = true;
		QuitText.enabled = true;
		HelpText.enabled = true;
	}

	public void CreditsPress()
	{
		CreditsMenu.enabled = true;
		PlayText.enabled = false;
		QuitText.enabled = false;
		HelpText.enabled = false;
	}


	public void StartGame()
	{
		Application.LoadLevel ("Level1");
		PlayerPrefs.SetInt ("CurrentPlayerScore", 0);
		PlayerPrefs.SetInt ("CurrentPlayerDeaths", 0);
		PlayerPrefs.SetFloat("CurrentPlayerTime",0);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}







	
	// Update is called once per frame
	void Update () {
	
	}
}
