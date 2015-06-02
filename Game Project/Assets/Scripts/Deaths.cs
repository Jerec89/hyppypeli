using UnityEngine;
using System.Collections;

public class Deaths : MonoBehaviour {

	public string SortingLayerName = "Default";
	public int SortingOrder = 0;
	
	TextMesh death;

	public static int deaths;

	// Use this for initialization
	void Start () {

		death = GetComponent <TextMesh> ();

		deaths = 0;

		gameObject.GetComponent<MeshRenderer> ().sortingLayerName = SortingLayerName;
		gameObject.GetComponent<MeshRenderer> ().sortingOrder = SortingOrder;
	}
	
	// Update is called once per frame
	void Update () {


		death.text = "Deaths: " + deaths;

		}


}
