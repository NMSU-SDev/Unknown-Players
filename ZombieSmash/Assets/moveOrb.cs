using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveOrb : MonoBehaviour {

	public KeyCode moveLeft;
	public KeyCode moveRight;

	public float horizVel = 0;
	public int laneNum = 2; 
	public string controlLocked = "false";

	public Transform boomObj;
	public Transform path1;
	public Transform colis;
	public float zValAdj;

	AudioSource audio1;
	AudioSource audio2;
	AudioSource audio3;
	// Use this for initialization
	void Start () {
		//int[] scores = new int[5];
		AudioSource[] audios = GetComponents<AudioSource>();
		audio1 = audios[0];
		audio2 = audios[1];
		audio3 = audios [2];
		zValAdj = PlayerPrefs.GetFloat ("speed");

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().velocity = new Vector3(0, 0, zValAdj);

		if ((Input.GetKey (moveLeft))) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (-5, 0, zValAdj);
		}
		if ((Input.GetKey (moveRight))) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (5, 0, zValAdj);
		}


	}

	public IEnumerator OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "killa") {
			zValAdj = 0;
			if(PlayerPrefs.GetInt("sound") == 1)
				audio1.Play();
			//Instantiate (boomObj, transform.position, boomObj.rotation);
			GM.Instance.gameStatus = "dead";
			GM.Instance.totalScore = (int)GM.Instance.timeTotal * 10 + GM.Instance.zombiesKilled * 100;
			if (GM.Instance.totalScore > PlayerPrefs.GetInt ("HighScore")) {
				if(PlayerPrefs.GetInt ("HighScore3") != 0)
					PlayerPrefs.SetInt ("HighScore4", PlayerPrefs.GetInt ("HighScore3"));
				if(PlayerPrefs.GetInt ("HighScore2") != 0)
					PlayerPrefs.SetInt ("HighScore3", PlayerPrefs.GetInt ("HighScore2"));
				if(PlayerPrefs.GetInt ("HighScore1") != 0)
					PlayerPrefs.SetInt ("HighScore2", PlayerPrefs.GetInt ("HighScore1"));
				if(PlayerPrefs.GetInt ("HighScore") != 0)
					PlayerPrefs.SetInt ("HighScore1", PlayerPrefs.GetInt ("HighScore"));
				PlayerPrefs.SetInt ("HighScore", GM.Instance.totalScore);
			}
			else if (GM.Instance.totalScore > PlayerPrefs.GetInt ("HighScore1")) {
				if(PlayerPrefs.GetInt ("HighScore3") != 0)
				PlayerPrefs.SetInt ("HighScore4", PlayerPrefs.GetInt ("HighScore3"));
				if(PlayerPrefs.GetInt ("HighScore2") != 0)
				PlayerPrefs.SetInt ("HighScore3", PlayerPrefs.GetInt ("HighScore2"));
				if(PlayerPrefs.GetInt ("HighScore1") != 0)
				PlayerPrefs.SetInt ("HighScore2", PlayerPrefs.GetInt ("HighScore1"));
				PlayerPrefs.SetInt ("HighScore1", GM.Instance.totalScore);
			}
			else if (GM.Instance.totalScore > PlayerPrefs.GetInt ("HighScore2")) {
				if(PlayerPrefs.GetInt ("HighScore3") != 0)
				PlayerPrefs.SetInt ("HighScore4", PlayerPrefs.GetInt ("HighScore3"));
				if(PlayerPrefs.GetInt ("HighScore2") != 0)
				PlayerPrefs.SetInt ("HighScore3", PlayerPrefs.GetInt ("HighScore2"));
				PlayerPrefs.SetInt ("HighScore2", GM.Instance.totalScore);
			}
			else if (GM.Instance.totalScore > PlayerPrefs.GetInt ("HighScore3")) {
				if(PlayerPrefs.GetInt ("HighScore3") != 0)
				PlayerPrefs.SetInt ("HighScore4", PlayerPrefs.GetInt ("HighScore3"));
				PlayerPrefs.SetInt ("HighScore3", GM.Instance.totalScore);
			}
			else if (GM.Instance.totalScore > PlayerPrefs.GetInt ("HighScore4")) {
				PlayerPrefs.SetInt ("HighScore4", GM.Instance.totalScore);
			}
		}

		if (other.gameObject.tag == "powerUp") {
			Destroy (other.gameObject);
			zValAdj = PlayerPrefs.GetFloat("speed") + 9.0f;
			yield return new WaitForSeconds(1.5f);
			zValAdj = PlayerPrefs.GetFloat("speed");
			if(PlayerPrefs.GetInt("sound") == 1)
				audio3.Play ();

		}

		if (other.gameObject.tag == "zomb") {
			GM.Instance.zombiesKilled += 1;
			Destroy (other.gameObject);
			if(PlayerPrefs.GetInt("sound") == 1)
				audio2.Play();
		}
	}

	void OnTriggerEnter(){
		Instantiate (path1, new Vector3(0, 0, GM.Instance.zPos), path1.rotation);
		GM.Instance.zPos += 40;
		Instantiate (colis, new Vector3 (0, 0, GM.Instance.zPosColid), colis.rotation);
		GM.Instance.zPosColid += 40;
	}


	IEnumerator stopSlide()
	{
		yield return new WaitForSeconds(.5f);
		horizVel = 0;
		controlLocked = "false";
	}
	IEnumerator stopSlide2()
	{
		yield return new WaitForSeconds(1.5f);
		zValAdj = PlayerPrefs.GetFloat("speed");
	}
		
}
