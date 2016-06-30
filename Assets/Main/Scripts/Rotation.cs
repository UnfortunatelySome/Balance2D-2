using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	public float rotationFactor;
	// Use this for initialization
	void Start () {
		gameObject.transform.localEulerAngles = new Vector3 (gameObject.transform.localEulerAngles.x, gameObject.transform.localEulerAngles.y, 360 * rotationFactor);
	}
}
