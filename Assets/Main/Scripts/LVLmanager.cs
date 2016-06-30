using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LVLmanager : MonoBehaviour {

	public int level;

	public Text levelText;

	// Use this for initialization
	void Start () {

		levelText.text = level.ToString();
	
	}


	public void LevelSelect(){

		Application.LoadLevel ("Level " + level);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
