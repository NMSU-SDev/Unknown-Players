using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extend : MonoBehaviour {
	public Transform terrain;
	public Transform rock1;
	public Transform rock2;
	public Transform rock3;
	public Transform rock4;
	public Transform mountain1;
	public Transform mountain2;
	public Transform mountain3;
	public Transform rock5;
	public Transform rock6;
	public Transform stone;
	public Transform plant;
	public Transform plant2;
	public Transform plant3;
	public float pos=80;
	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter()
	{
	  
		Instantiate (terrain, new Vector3 (0.0f, 0.0f, pos), Quaternion.identity);
		Instantiate (rock1, new Vector3 (0.0f, 0.0f, pos), Quaternion.identity);
		Instantiate (rock2, new Vector3 (0.0f, 0.0f, pos), Quaternion.identity);
		Instantiate (rock3, new Vector3 (0.0f, 0.0f, pos), Quaternion.identity);
		Instantiate (rock4, new Vector3 (0.0f, 0.0f, pos), Quaternion.identity);
		Instantiate (rock5, new Vector3 (0.0f, 0.0f, pos), Quaternion.identity);
		Instantiate (rock6, new Vector3 (0.0f, 0.0f, pos), Quaternion.identity);
		Instantiate (plant, new Vector3 (0.0f, 0.0f, pos), Quaternion.identity);
		Instantiate (plant2, new Vector3 (0.0f, 0.0f, pos), Quaternion.identity);
		Instantiate (plant3, new Vector3 (0.0f, 0.0f, pos), Quaternion.identity);
		Instantiate (stone, new Vector3 (0.0f, 0.0f, pos), Quaternion.identity);
		pos += 40;
	
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
