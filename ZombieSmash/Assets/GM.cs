using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {
	public static GM Instance;
	public int zombiesKilled = 0;
	public int totalScore = 0;
	public float timeTotal = 0;

	public float zLeftOneL = 44;
	public float zLeftTwoL = 68;
	public float zRightOneL = 56;
	public float zRightTwoL = 83;

	public float vertVel = 0;
	public float zPos = 80;
	public float zPosColid = 60;

	public float zHolder = 3;

	public float ob1pos = 45;
	public float ob2pos = 55;
	public float ob3pos = 65;

	public float BP = 80;

	public float powerPos = 75;

	public float waitToLoad = 0;

	public Transform bb1;
	public Transform bb2;
	public Transform bb;

	public string gameStatus = "";
 
	// Use this for initialization
	void Start () {
		Instance = this;
		Instantiate (bb, new Vector3 (0, 0, 40), bb.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		timeTotal += Time.deltaTime;

		if(gameStatus == "dead"){
			waitToLoad += Time.deltaTime;
		}
		if (waitToLoad > 0.9f) {
			SceneManager.LoadScene ("GameOver");
		}
	}


}
