using UnityEngine;
using System.Collections;

public class GameOverCont : MonoBehaviour {

	public string SortingLayerName = "Default";
	public int SortingOrder = 0;
	
	TextMesh gameOver;

	// Use this for initialization
	void Start () {

		gameOver = GetComponent <TextMesh> ();

		gameOver.text = "";

		gameObject.GetComponent<MeshRenderer> ().sortingLayerName = SortingLayerName;
		gameObject.GetComponent<MeshRenderer> ().sortingOrder = SortingOrder;
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerControl.gameover == true) {
			gameOver.text = "Game Over";
		}

	}
}
