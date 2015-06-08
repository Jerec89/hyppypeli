using UnityEngine;
using System.Collections;

public class track2 : MonoBehaviour {

	public float firerate;
	public float delay;
	public GameObject shot;
	public Transform shotSpawn;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Fire", delay, firerate);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Fire(){
		Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
	}
}
