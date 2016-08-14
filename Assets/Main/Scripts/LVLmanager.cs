using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LVLmanager : MonoBehaviour {

	public int level;
	public Text levelText;
	public Sprite Lock;
	public Sprite Lvl;

	private Image image;
	private bool LockActive;

	// Use this for initialization
	void Start () {

		image = gameObject.GetComponent<Image>();


	}


	public void LevelSelect(){

		if (LockActive.Equals (false)) {

			Application.LoadLevel ("Level " + level);
		} else {
			return;
		}

	}
	
	// Update is called once per frame
	void Update () {

		if (BackgroundDataSaver.maxReachedLevel == 0) {
			levelText.text = "";
			image.sprite = Lock;
			LockActive = true;
		} else {

			if (BackgroundDataSaver.maxReachedLevel + 1 < level) {

				levelText.text = "";
				image.sprite = Lock;
				LockActive = true;


			} else if (BackgroundDataSaver.maxReachedLevel + 1 >= level) {

				levelText.text = level.ToString ();
				image.sprite = Lvl;
				LockActive = false;

			}
		}
	
	}
}
