using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public Canvas HelpMenu;
	public Canvas CreditsMenu;
	public Canvas LeaderMenu;

	public Button PlayText;
	public Button HelpText;
	public Button QuitText;
	public Button CreditsText;
	public Button LeaderText;

	// Use this for initialization
	void Start () {
	
		HelpMenu = HelpMenu.GetComponent<Canvas> ();
		CreditsMenu = CreditsMenu.GetComponent<Canvas> ();
		LeaderMenu = LeaderMenu.GetComponent<Canvas> ();

		PlayText = PlayText.GetComponent<Button> ();
		HelpText = HelpText.GetComponent<Button> ();
		QuitText = QuitText.GetComponent<Button> ();
		CreditsText = CreditsText.GetComponent<Button> ();
		LeaderText = LeaderText.GetComponent<Button> ();

		HelpMenu.enabled = false;
		CreditsMenu.enabled = false;
		LeaderMenu.enabled = false;

	}

	public void HelpPress()
	{
		HelpMenu.enabled = true;
		CreditsMenu.enabled = false;
		LeaderMenu.enabled = false;

	}

	public void ClosePress()
	{
		HelpMenu.enabled = false;
		CreditsMenu.enabled = false;
		LeaderMenu.enabled = false;
	}
	
	public void CreditsPress()
	{
		CreditsMenu.enabled = true;
		HelpMenu.enabled = false;
		LeaderMenu.enabled = false;

	}

	public void LeaderPress()
	{
		CreditsMenu.enabled = false;
		HelpMenu.enabled = false;
		LeaderMenu.enabled = true;
		
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
