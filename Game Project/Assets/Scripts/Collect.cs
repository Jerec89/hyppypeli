using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {
	
	public int PointsToAdd;

	// objektin keräys
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player1") {
			Destroy (gameObject);
			ScoreCont.AddPoints(PointsToAdd);

		}
	}

}