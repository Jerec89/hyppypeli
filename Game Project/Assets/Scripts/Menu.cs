using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public Canvas HelpMenu;
	public Button PlayText;
	public Button HelpText;
	public Button QuitText;

	// Use this for initialization
	void Start () {
	
		HelpMenu = HelpMenu.GetComponent<Canvas> ();
		PlayText = PlayText.GetComponent<Button> ();
		HelpText = HelpText.GetComponent<Button> ();
		QuitText = QuitText.GetComponent<Button> ();

		HelpMenu.enabled = false;

	}

	public void HelpPress()
	{
		HelpMenu.enabled = true;
		PlayText.enabled = false;
		QuitText.enabled = false;
	}

	public void ClosePress()
	{
		HelpMenu.enabled = false;
		PlayText.enabled = true;
		QuitText.enabled = true;
	}

	public void StartGame()
	{
		Application.LoadLevel ("Level1");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}







	
	// Update is called once per frame
	void Update () {
	
	}
}
