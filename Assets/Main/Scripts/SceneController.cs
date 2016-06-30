using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

	public void StartButton (){

		Application.LoadLevel ("Level 0");

	}
	public void LevelSelectButton(){
		Application.LoadLevel ("LVL select");
	}
	public void SettingsButton(){
	}
}
