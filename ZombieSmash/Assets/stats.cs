using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "zombtxt") {
			GetComponent<TextMesh> ().text = "Zombies: " + GM.Instance.zombiesKilled;
		}
		if (gameObject.name == "timetxt") {
			GetComponent<TextMesh> ().text = "Time Elapsed: " + (int)GM.Instance.timeTotal + " seconds";
		}
		if (gameObject.name == "totalScore") {
			GetComponent<TextMesh> ().text = "Total Score: " + GM.Instance.totalScore;
		}
		if(gameObject.name == "highScore") {
			GetComponent<TextMesh> ().text = "HighScore: " + PlayerPrefs.GetInt ("HighScore");
	}
}
}