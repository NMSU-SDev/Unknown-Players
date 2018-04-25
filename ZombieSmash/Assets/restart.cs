using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GM.Instance.gameStatus = "";
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
