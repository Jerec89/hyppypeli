using UnityEngine;
using System.Collections;

public class ScoreCont : MonoBehaviour {

	public string SortingLayerName = "Default";
	public int SortingOrder = 0;

	public static int score;

	TextMesh Text;
	

	// Use this for initialization
	void Start () {

		Text = GetComponent <TextMesh> ();
	
		gameObject.GetComponent<MeshRenderer> ().sortingLayerName = SortingLayerName;
		gameObject.GetComponent<MeshRenderer> ().sortingOrder = SortingOrder;

	}
	
	// Update is called once per frame
	void Update () {
	
		Text.text = "Score: " + score;

	}
}
