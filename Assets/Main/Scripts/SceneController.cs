﻿using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

	public void StartButton (){

		Application.LoadLevel ("Tutorial");

	}
	public void LevelSelectButton(){
		Application.LoadLevel ("LVL select");
	}
	public void SettingsButton(){
		Application.LoadLevel ("Settings");
	}
	public void HomeButton(){
		Application.LoadLevel ("Main Menu");
	}
}
