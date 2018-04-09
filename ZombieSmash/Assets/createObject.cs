using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public Transform spawnpoint;
	public GameObject prefab;

	void OnTriggerEnter(){
		Instantiate(prefab, spawnpoint.position, spawnpoint.rotation);
}
}
