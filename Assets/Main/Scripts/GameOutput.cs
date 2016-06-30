using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOutput : MonoBehaviour {
	Text text;
	public string defMessage;
	public string winMessage;
	public string lossMessage;
	GameController gameController;
	// Use this for initialization
	void Start () {
		text = this.GetComponent<Text> ();
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameController.winState == "InProgress") {
			text.text = defMessage;
		} else if (gameController.winState == "Victory") {
			text.text = winMessage;
		} else if (gameController.winState == "Loss") {
			text.text = lossMessage;
		}
	}
}
