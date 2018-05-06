using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScores : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "hs1") {
			GetComponent<TextMesh> ().text = "1)    " + PlayerPrefs.GetInt ("HighScore");

		}
		if (gameObject.name == "hs2") {
			GetComponent<TextMesh> ().text = "2)    " + PlayerPrefs.GetInt ("HighScore1");

		}
		if (gameObject.name == "hs3") {
			GetComponent<TextMesh> ().text = "3)    " + PlayerPrefs.GetInt ("HighScore2");

		}
		if (gameObject.name == "hs4") {
			GetComponent<TextMesh> ().text = "4)    " + PlayerPrefs.GetInt ("HighScore3");

		}
		if (gameObject.name == "hs5") {
			GetComponent<TextMesh> ().text = "5)    " + PlayerPrefs.GetInt ("HighScore4");
		}

	}
}
