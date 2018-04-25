using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {

	public Text scoreText;
	// Update is called once per frame
	void Update () {
		scoreText.text = ( GM.timeTotal * 10 + GM.zombiesKilled * 100).ToString();
	}
}
