using UnityEngine;
using System.Collections;

public class MovingUp : MonoBehaviour {
	public float upSpeed;
	float lastTime;
	// Use this for initialization
	void Start () {
		lastTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad - lastTime >= 1) {
			lastTime = Time.time;
			transform.Translate (0, upSpeed, 0);
		}
	}
}
