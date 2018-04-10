using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieLeft : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().velocity = new Vector3(0.2f, 0, -0.6f);

	}
	void OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "zomb") 
			Destroy (other.gameObject);
	}
}
