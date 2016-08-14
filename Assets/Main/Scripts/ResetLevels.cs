using UnityEngine;
using System.Collections;

public class ResetLevels : MonoBehaviour {

	public void Reset(){

		PlayerPrefs.DeleteAll ();
		PlayerPrefs.Save ();
		print ("Max level is " + PlayerPrefs.GetInt("MaxLevel")) ;

	}

	public void back(){
		Application.LoadLevel ("Main Menu");
	}
}
