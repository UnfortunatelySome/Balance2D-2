using UnityEngine;
using System.Collections;

public class BackgroundDataSaver : MonoBehaviour {

	public static int maxReachedLevel;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);

		maxReachedLevel = GameController.maxLevel;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
