using UnityEngine;
using System.Collections;

public class Indicator : MonoBehaviour {
	public GameController gameController;
	public Sprite icon;
	public int offset;
	// Use this for initialization
	void Start () {
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
		int i = gameController.currentIndex;
		if (gameController.blockList [offset + i] == null) {
			icon= null;
		} else {
			icon = gameController.blockList [offset + i].GetComponent<Icon> ().blockIcon;
		}
		gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = icon;
	}
}
