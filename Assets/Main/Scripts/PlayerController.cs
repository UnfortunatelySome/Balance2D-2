using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float tiltMultiplier;
	public float tilt;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tilt = Input.acceleration.x;
		//gameObject.transform.localEulerAngles = new Vector3 (gameObject.transform.localEulerAngles.x, gameObject.transform.localEulerAngles.y, -tilt * tiltMultiplier);
		//gameObject.transform.Rotate (0, 0, -tilt * tiltMultiplier);
		transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.Euler(0,0,-tilt * tiltMultiplier),speed);
	}
}
