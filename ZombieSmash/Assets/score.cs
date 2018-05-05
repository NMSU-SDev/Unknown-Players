using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {

	public Text scoreText;
	// Update is called once per frame
	void Update () {
		scoreText.text =((int) ( GM.Instance.timeTotal * 10 + GM.Instance.zombiesKilled * 100)).ToString();
	}
}
