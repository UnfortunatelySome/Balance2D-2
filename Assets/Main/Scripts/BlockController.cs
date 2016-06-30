using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class BlockController : MonoBehaviour {
	public bool active;
	public float leftRight;

	void Update () {
		if (active) {
			if (CrossPlatformInputManager.GetButton ("Right")) {
				transform.Translate (new Vector3 (leftRight * Time.deltaTime, 0, 0),Space.World);
			} else if (CrossPlatformInputManager.GetButton ("Left")) {
				transform.Translate (new Vector3 (-leftRight * Time.deltaTime, 0, 0),Space.World);
			}
			if (CrossPlatformInputManager.GetButtonDown ("Release")) {
				active = false;
				gameObject.GetComponent<Rigidbody2D> ().isKinematic = false;
				gameObject.GetComponent<Collider2D> ().isTrigger = false;
			}
		}
	}

	public bool isActive(){
		return active;
	}
}
