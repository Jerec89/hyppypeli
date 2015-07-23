using UnityEngine;
using System.Collections;

public class DeathParticle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		DontDestroyOnLoad (gameObject);
		StartCoroutine(PartWait());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator PartWait() {

		yield return new WaitForSeconds(1);
		Destroy (gameObject);

	}
}
