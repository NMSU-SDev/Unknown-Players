using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {

	public static int zombiesKilled = 0;
	public static int totalScore = 0;
	public static float timeTotal = 0;

	public static float vertVel = 0;
	public static float zPos = 80;
	public static float zPosColid = 60;
	public static float zValAdj = 2.0f;

	public float waitToLoad = 0;

	public Transform bb1;
	public Transform bb2;
	public Transform bb;

	public static string gameStatus = "";
 
	// Use this for initialization
	void Start () {
		Instantiate (bb, new Vector3 (0, 0, 40), bb.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		timeTotal += Time.deltaTime;

		if(gameStatus == "dead"){
			waitToLoad += Time.deltaTime;
		}
		if (waitToLoad > 2) {
			SceneManager.LoadScene ("GameOver");
		}
	}


}
