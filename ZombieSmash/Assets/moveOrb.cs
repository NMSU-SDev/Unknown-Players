﻿using System.Collections;
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

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().velocity = new Vector3(horizVel, GM.vertVel, 4*GM.zValAdj);

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
			Destroy (gameObject);
			GM.zValAdj = 0;
			Instantiate (boomObj, transform.position, boomObj.rotation);
			GM.gameStatus = "dead";
		}

		if (other.gameObject.tag == "powerUp") {
			Destroy (other.gameObject);
			GM.zValAdj = 8;
			StartCoroutine (stopSlide2 ());

		}
		if (other.gameObject.tag == "spawner") {
			/*Instantiate (z1, new Vector3 (-1.5f, 1.55f, GM.zLeftOneL), z1.rotation);
			Instantiate (z2, new Vector3 (-1.5f, 1.55f, GM.zLeftTwoL), z2.rotation);
			Instantiate (z3, new Vector3 (1.5f, 1.55f, GM.zRightOneL), z3.rotation);
			Instantiate (z4, new Vector3 (1.5f, 1.55f, GM.zLeftTwoL), z4.rotation);
			GM.zLeftOneL += 30;
			GM.zLeftTwoL += 30;
			GM.zRightOneL += 30;
			GM.zRightTwoL += 30;
			Instantiate (path1, new Vector3(0, 0, GM.zPos), path1.rotation);
			GM.zPos += 40;
			Instantiate (colis, new Vector3 (0, 0, GM.zPosColid), colis.rotation);
			GM.zPosColid += 40;
			GM.zValAdj = 1;
			Destroy (other.gameObject); */
		}
		if (other.gameObject.tag == "zomb") {
			GM.zombiesKilled += 1;
			Destroy (other.gameObject);
		}
	}

	void OnTriggerEnter(){
		Instantiate (z1, new Vector3 (-1.5f, 1.55f, GM.zLeftOneL), z1.rotation);
		Instantiate (z2, new Vector3 (-1.5f, 1.55f, GM.zLeftTwoL), z2.rotation);
		Instantiate (z3, new Vector3 (1.5f, 1.55f, GM.zRightOneL), z3.rotation);
		Instantiate (z4, new Vector3 (1.5f, 1.55f, GM.zLeftTwoL), z4.rotation);
		GM.zLeftOneL += 30;
		GM.zLeftTwoL += 30;
		GM.zRightOneL += 30;
		GM.zRightTwoL += 30;
		Instantiate (path1, new Vector3(0, 0, GM.zPos), path1.rotation);
		GM.zPos += 40;
		Instantiate (colis, new Vector3 (0, 0, GM.zPosColid), colis.rotation);
		GM.zPosColid += 40;
		GM.zValAdj = 1;
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
		GM.zValAdj = 2;
	}
}
