using UnityEngine;
using System.Collections;

public class tracking : MonoBehaviour {

	private Transform target = null;

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
		if (target == null) {
			return;
		} else {
			Vector3 dir = target.position - transform.position;
			float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		}
		}


	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player1") {
			target = coll.transform;

		}

	}

	void Fire(){
		Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
	}


	

}