using UnityEngine;
using System.Collections;

public class ProgressBar : MonoBehaviour {
	public GameController gameController;
	public float startWidth;
	public float endWidth;
	public float startX;
	public float endX;
	public float progress;
	void Start (){
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
	}
	void Update () {
		RectTransform spriteTransform = gameObject.GetComponent<RectTransform> ();
		progress = (gameController.currentIndex)/(float)gameController.blockList.Length;
		spriteTransform.localPosition = new Vector3((startX - endX) * (1-progress),0,0);
		spriteTransform.sizeDelta = new Vector2((endWidth-startWidth)*progress,spriteTransform.sizeDelta.y);
	}
}
