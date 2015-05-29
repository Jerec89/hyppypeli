using UnityEngine;
using System.Collections;

public class tracking : MonoBehaviour {

	private Transform target = null;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		if (target == null)
			return;
			Vector3 dir = target.position - transform.position;
			float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		
		
		
		}


	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player1") {
			target = coll.transform;
			Debug.Log ("tracking");

		}

	}

	void OnTriggerExit2D(){
		if (gameObject.tag == "Player1") {
			target = null;
			Debug.Log ("not tracking");
		
	}

	}
}