using UnityEngine;
using System.Collections;

public class area : MonoBehaviour {

	public float range;


	public LayerMask playerLayer;
	
	public bool inRange = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		inRange = Physics2D.OverlapCircle (transform.position, range, playerLayer);
	}

	void OnDrawGizmosSelected(){
		
		Gizmos.DrawSphere (transform.position, range);
		                                                
		
	}
}
