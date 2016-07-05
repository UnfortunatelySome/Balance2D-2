using UnityEngine;
using System.Collections;

public class ButtonHide : MonoBehaviour {
	public GameObject nextButton;
	public GameObject playButton;
	public GameObject prevButton;
	GameController gameController;
	void Start(){
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
	}
	void Update(){	
		if (gameController.maximumLevel + 1 <= gameController.level) {
			nextButton.SetActive (false);
		} else {
			nextButton.SetActive (true);
		}
	}
}
