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

	void OnTriggerEnter(){
		Instantiate (obj1, new Vector3 (-1.5f, 0, GM.Instance.ob1pos), obj1.rotation);
		Instantiate (obj2, new Vector3 (1.5f, 0.5f, GM.Instance.ob2pos), obj2.rotation);
		Instantiate (obj3, new Vector3 (1.5f, 1.5f, GM.Instance.ob3pos), obj3.rotation);
		Instantiate (power, new Vector3 (0, 1.5f, GM.Instance.powerPos), power.rotation);
		GM.Instance.ob1pos += 40;
		GM.Instance.ob2pos +=40;
		GM.Instance.ob3pos += 40;
		GM.Instance.powerPos += 40;

	}
}
