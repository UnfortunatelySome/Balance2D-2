using UnityEngine;
using System.Collections;

public class isFailed : MonoBehaviour {
	public bool failed;
	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Block") {
			failed = true;
		}
	}
}
