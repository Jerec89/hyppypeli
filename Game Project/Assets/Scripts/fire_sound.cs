using UnityEngine;
using System.Collections;

public class fire_sound : MonoBehaviour {
	
	public float firerate;
	public float delay;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Fire", delay, firerate);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void Fire(){
		GetComponent<AudioSource> ().Play ();
	}
}
