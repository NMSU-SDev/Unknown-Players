using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colis : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	public Transform spawnpoint;
	public GameObject prefab;

	void OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "zomb") 
			Destroy (other.gameObject);
	}

}


