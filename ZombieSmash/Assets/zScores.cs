using UnityEngine.UI;
using UnityEngine;

public class zScores : MonoBehaviour {

	public Text ZscoreText;
	// Update is called once per frame
	void Update () {
		ZscoreText.text = (GM.Instance.zombiesKilled).ToString();
	}
}
