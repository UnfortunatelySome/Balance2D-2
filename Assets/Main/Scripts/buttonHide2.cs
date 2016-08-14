using UnityEngine;
using System.Collections;

public class buttonHide2 : MonoBehaviour {
	public GameObject nextButton;
	public GameObject playButton;
	public GameObject prevButton;
	GameController gameController;
	public static int finish;
	void Start(){
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
	}
	void Update(){	

		if (gameController.winState == "Victory") {
			nextButton.SetActive (true);
		} else if (gameController.winState == "Loss") {
			nextButton.SetActive (false);
		}
	}
}
