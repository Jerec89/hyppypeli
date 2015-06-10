using UnityEngine;
using System.Collections;

public class tracking : MonoBehaviour {

	public Transform target;

	public float firerate;
	public float delay;
	public GameObject shot;
	public Transform shotSpawn;

	public GameObject area;
	
	private Quaternion rotation;
	private float rotSpeed = 5;



	// Use this for initialization
	void Start () {
		InvokeRepeating ("Fire", delay, firerate);
		rotation = transform.rotation;

	}
	
	// Update is called once per frame
	void Update () {

		if (area.GetComponent<area> ().inRange) {
			
			Vector3 dir = target.position - transform.position;
			float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);	
		} else
			transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.time * rotSpeed);


	
		}
	

	void Fire(){
		Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
	}
	



}