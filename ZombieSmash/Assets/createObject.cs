using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

	public Transform obj1;
	public Transform obj2;
	public Transform obj3;
	public Transform power;

	public Transform z1;
	public Transform z2;
	public Transform z3;
	public Transform z4;

	void OnTriggerEnter(){
		Instantiate (z1, new Vector3 (Random.Range(-6.5f,6.5f), 0.6f, GM.Instance.zLeftOneL), z1.rotation);
		Instantiate (z2, new Vector3 (Random.Range(-6.5f,6.5f), 0.6f, GM.Instance.zLeftTwoL + Random.Range(-6.0f,6.0f)), z2.rotation);
		Instantiate (z3, new Vector3 (-2f, 0.6f, GM.Instance.zRightOneL), z3.rotation);
		Instantiate (z4, new Vector3 (-2f, 0.6f, GM.Instance.zLeftTwoL + Random.Range(-13.0f,13.0f)), z4.rotation);
		Instantiate (z2, new Vector3 (Random.Range(-6.5f,6.5f), 0.6f, GM.Instance.zLeftTwoL + 10), z2.rotation);
		GM.Instance.zLeftOneL += 40;
		GM.Instance.zLeftTwoL += 40;
		GM.Instance.zRightOneL += 40;
		GM.Instance.zRightTwoL += 40;
		Instantiate (obj1, new Vector3 (Random.Range(-6.5f,6.5f), 1, GM.Instance.ob1pos + Random.Range(-3.0f,3.0f)), obj1.rotation);
		Instantiate (obj2, new Vector3 (Random.Range(-6.5f,6.5f), 1, GM.Instance.ob2pos+ Random.Range(-3.0f,3.0f)), obj2.rotation);
		Instantiate (obj3, new Vector3 (1.5f, 1, GM.Instance.ob3pos), obj3.rotation);
		Instantiate (obj3, new Vector3 (1.5f, 1, GM.Instance.ob3pos + 10), obj3.rotation);

		Instantiate (power, new Vector3 (0, 1, GM.Instance.powerPos), power.rotation);
		if (PlayerPrefs.GetFloat ("speed") == 16.0f) {
			Instantiate (obj1, new Vector3 (-2.8f, 1, GM.Instance.ob1pos + 20), obj1.rotation);
			Instantiate (obj2, new Vector3 (2.6f, 1, GM.Instance.ob2pos + 14), obj2.rotation);
			Instantiate (obj3, new Vector3 (0, 1, GM.Instance.ob3pos + 30), obj3.rotation);
		}
		GM.Instance.ob1pos += 40;
		GM.Instance.ob2pos +=40;
		GM.Instance.ob3pos += 40;
		GM.Instance.powerPos += 40;

			

	}
}
