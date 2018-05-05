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
	public Transform z1;
	public Transform z2;
	public Transform z3;
	public Transform z4;

	AudioSource audio1;
	AudioSource audio2;
	AudioSource audio3;
	// Use this for initialization
	void Start () {
		AudioSource[] audios = GetComponents<AudioSource>();
		audio1 = audios[0];
		audio2 = audios[1];
		audio3 = audios [2];

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().velocity = new Vector3(horizVel, GM.Instance.vertVel, 4*GM.Instance.zValAdj);

		if ((Input.GetKeyDown(moveLeft)) &&(laneNum > 0) && (controlLocked == "false")) {
			horizVel = -2;
			laneNum -= 1;
			StartCoroutine (stopSlide ());
			controlLocked = "true";
		}
		if ((Input.GetKeyDown(moveRight))&&(laneNum < 6) && (controlLocked == "false")) {
			horizVel = 2;
			laneNum += 1;
			StartCoroutine (stopSlide ());
			controlLocked = "true";
		}

	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "killa") {
			GM.Instance.zValAdj = 0;
			audio1.Play();
			//Instantiate (boomObj, transform.position, boomObj.rotation);
			GM.Instance.gameStatus = "dead";
		}

		if (other.gameObject.tag == "powerUp") {
			Destroy (other.gameObject);
			GM.Instance.zValAdj = 8;
			StartCoroutine (stopSlide2 ());
			audio3.Play ();

		}

		if (other.gameObject.tag == "zomb") {
			GM.Instance.zombiesKilled += 1;
			Destroy (other.gameObject);
			audio2.Play();
		}
	}

	void OnTriggerEnter(){
		Instantiate (z1, new Vector3 (-3.5f, 0.6f, GM.Instance.zLeftOneL), z1.rotation);
		Instantiate (z2, new Vector3 (-3.5f, 0.6f, GM.Instance.zLeftTwoL), z2.rotation);
		Instantiate (z3, new Vector3 (3.5f, 0.6f, GM.Instance.zRightOneL), z3.rotation);
		Instantiate (z4, new Vector3 (3.5f, 0.6f, GM.Instance.zLeftTwoL), z4.rotation);
		GM.Instance.zLeftOneL += 30;
		GM.Instance.zLeftTwoL += 30;
		GM.Instance.zRightOneL += 30;
		GM.Instance.zRightTwoL += 30;
		Instantiate (path1, new Vector3(0, 0, GM.Instance.zPos), path1.rotation);
		GM.Instance.zPos += 40;
		Instantiate (colis, new Vector3 (0, 0, GM.Instance.zPosColid), colis.rotation);
		GM.Instance.zPosColid += 40;
		GM.Instance.zValAdj = 1;
	}


	IEnumerator stopSlide()
	{
		yield return new WaitForSeconds(.5f);
		horizVel = 0;
		controlLocked = "false";
	}
	IEnumerator stopSlide2()
	{
		yield return new WaitForSeconds(2.5f);
		GM.Instance.zValAdj = GM.Instance.zHolder;
	}
}
