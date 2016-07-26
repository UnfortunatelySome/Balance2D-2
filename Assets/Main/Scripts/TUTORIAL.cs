using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TUTORIAL : MonoBehaviour {

	public Animator Bottom;
	public Animator Top;
	public Animator Left;
	public Animator Right;
	public Text Bottomtext;
	public Text Toptext;
	public Text Lefttext;
	public Text Righttext;
	public Text Finish;
	public GameObject Next;
	private int ButtonCount;

	// Use this for initialization
	void Start () {

		Bottomtext.text = "";
		Toptext.text = "";
		Lefttext.text = "";
		Righttext.text = "";
		Finish.text = "";

		ButtonCount = 0;

		Next.SetActive (true);


	}
	
	// Update is called once per frame
	void Update () {

		print (ButtonCount);
		if (ButtonCount == 0)  {
			Bottomtext.text = "This button allows you to drop the shape.";
			Bottom.SetTrigger ("BottomOk");
		}
		else if (ButtonCount == 1) {
			Bottomtext.text = "";
			Bottom.ResetTrigger("BottomOk");
			Bottom.SetTrigger ("back");
			Lefttext.text = "This button allows the shape to move Left";
			Left.SetTrigger ("LeftOK");
		}
		else if (ButtonCount == 2) {
			Lefttext.text = "";
			Left.ResetTrigger("LeftOK");
			Left.SetTrigger ("back");
			Righttext.text = "This button allows the shape to move right";
			Right.SetTrigger ("RightOK");
		}
		else if (ButtonCount == 3) {
			Righttext.text = "";
			Right.ResetTrigger("RightOK");
			Right.SetTrigger ("back");
			Toptext.text = "This button allows you to pause the game";
			Top.SetTrigger ("TopOK");
		}
		else if (ButtonCount == 4) {
			Toptext.text = "";
			Top.ResetTrigger("TopOK");
			Top.SetTrigger ("back");
			Finish.text = "Great now finish this level!!!!";
		}
		else if (ButtonCount == 5) {
			Finish.text = "";
			Next.SetActive (false);
		}
	}

	public void ButtonClicks(){
		ButtonCount += 1;
	}

}
