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

	void OnTriggerEnter(){
		Instantiate (obj1, new Vector3 (-1.5f, 1.55f, GM.ob1pos), obj1.rotation);
		Instantiate (obj2, new Vector3 (1.5f, 1.55f, GM.ob2pos), obj2.rotation);
		Instantiate (obj3, new Vector3 (1.5f, 1.55f, GM.ob3pos), obj3.rotation);
		GM.ob1pos += 40;
		GM.ob2pos +=40;
		GM.ob3pos += 40;

	}
}
