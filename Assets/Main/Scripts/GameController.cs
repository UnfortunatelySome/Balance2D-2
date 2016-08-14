using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Advertisements;

public class GameController : MonoBehaviour {
	Camera mainCamera;
	public Transform spawnPos;
	public Rigidbody2D block;
	public bool ready;
	public int score;
	public float waitTime;
	public GameObject[] blockList;
	public int currentIndex;
	public string winState;
	public int level;
	public static int maxLevel;
	public int maximumLevel;
	public float winTimer; 
	public bool paused;
	public GameObject pauseMenu;
	public GameObject gameGUI;
	public GameObject currentBlock;

	// Use this for initialization
	void Start () {
		mainCamera = gameObject.GetComponentInChildren<Camera> ();
		currentIndex = 0;
		pauseMenu = GameObject.Find ("PauseMenu");
		gameGUI = GameObject.Find ("MobileSingleStickControl");
	}
	
	// Update is called once per frame
	void Update () {
		maximumLevel = maxLevel;
		if (CrossPlatformInputManager.GetButtonDown ("Next")) {
			nextScene ();
		} else if (CrossPlatformInputManager.GetButtonDown ("Previous")) {
			previousScene ();
		}
		if (ready) {
			StartCoroutine (spawn());
		}
		if (gameObject.GetComponentInChildren<isFailed> ().failed) {
			winState = "Loss";
			StartCoroutine (pauseCoroutine ());//This starts a coroutine called pauseCoroutine(), it does not start and then pause a coroutine
		} else if (currentIndex == blockList.Length) {
			winState = "PossibleVictory";

			if (winCheck ()) {
				winState = "Victory";
				if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex > maxLevel + 1) {
					maxLevel++;

					PlayerPrefs.SetInt ("MaxLevel" , maxLevel);
					PlayerPrefs.Save ();
					print ("Max level is " + PlayerPrefs.GetInt("MaxLevel")) ;
				}
				StartCoroutine (pauseCoroutine ());
			}
		} else {
			winState = "InProgress";
		}
		if (CrossPlatformInputManager.GetButtonDown ("Pause")) {
			if (!paused) {
				paused = true;
			} else if (winState == "Loss"||winState=="Victory"&&paused==true) {
				UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex);
				showAd ();
			}
			else {
				paused = false;
			}
		}
		pause ();

	}

	public IEnumerator spawn(){
		ready = false;
		bool working = true;
		currentBlock = null;
		if (working) {
			currentBlock =GameObject.Instantiate (blockList [currentIndex], spawnPos.position, spawnPos.rotation) as GameObject;
			working = false;
			yield return new WaitForSeconds(1);
		}
		while (currentBlock.GetComponent<BlockController> ().active) {
			yield return null;
		}
		currentIndex++;
		working = true;
		if (working) {
			working = false;
			yield return new WaitForSeconds (2f);
		}
		if (currentIndex == blockList.Length) {
			ready = false;
		} else {
			ready = true;
		}
		yield return null;
	}
	public bool winCheck(){
		winTimer -= Time.deltaTime;
		if (winTimer <= 0) {
			return true;
		}
		return false;
	}
	public void handleWin(string winState){
		
	}
	public void pause(){
		if (paused) {
			Time.timeScale = 0;
			gameGUI.SetActive (false);
			pauseMenu.SetActive (true);
		} else if (!paused) {
			Time.timeScale = 1;
			gameGUI.SetActive (true);
			pauseMenu.SetActive (false);
		}
	}
	public void nextScene(){
		UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex + 1);
		showAd ();
	}
	public void previousScene(){
		UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex - 1);
	}
	public void goToScene(int scene){
		UnityEngine.SceneManagement.SceneManager.LoadScene (scene);
	}
	public IEnumerator pauseCoroutine(){
		int i = 0;
		while (i != 1) {
			i++;
			yield return new WaitForSeconds (1f);
		}
		paused = true;
		yield return null;
	}
	public void showAd(){
		if (Random.Range (0, 4) == 1) {
			if (Advertisement.IsReady ()) {
				Advertisement.Show ();
			}
		}
	}
}
