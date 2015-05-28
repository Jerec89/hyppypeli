using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class TimeCont : MonoBehaviour {

	public string SortingLayerName = "Default";
	public int SortingOrder = 0;

	TextMesh TimeText;

	Stopwatch stopwatch = new Stopwatch();

	// Use this for initialization
	void Start () {

		gameObject.GetComponent<MeshRenderer> ().sortingLayerName = SortingLayerName;
		gameObject.GetComponent<MeshRenderer> ().sortingOrder = SortingOrder;

		TimeText = GetComponent <TextMesh> ();
	
		stopwatch.Start();
	}
	
	// Update is called once per frame
	void Update () {

		TimeText.text = "Time: " + stopwatch.Elapsed.Minutes + " min " + stopwatch.Elapsed.Seconds + " s";
	
	}
}
