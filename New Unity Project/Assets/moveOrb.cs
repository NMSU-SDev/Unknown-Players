using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOrb : MonoBehaviour {

	public KeyCode moveLeft;
	public KeyCode moveRight;

	public float horizVel = 0;
	public int laneNum = 2; 
	public string controlLocked = "false";

	public Transform boomObj;
	public Transform path1;
	public Transform colis;

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
		}

		if (other.gameObject.name == "powerUp") {
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "spawner") {
			Instantiate (path1, new Vector3(0, 0, GM.zPos), path1.rotation);
			GM.zPos += 40;
			Instantiate (colis, new Vector3 (0, 0, GM.zPosColid), colis.rotation);
			GM.zPosColid += 40;
			GM.zValAdj = 1;
		}
				
	}

	IEnumerator stopSlide()
	{
		yield return new WaitForSeconds(.5f);
		horizVel = 0;
		controlLocked = "false";
	}
}
