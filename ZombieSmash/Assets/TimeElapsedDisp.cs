﻿using UnityEngine.UI;
using UnityEngine;

public class TimeElapsedDisp : MonoBehaviour {

	public Text TimeText;
	// Update is called once per frame
	void Update () {
		TimeText.text = (GM.Instance.timeTotal).ToString();
	}
}

