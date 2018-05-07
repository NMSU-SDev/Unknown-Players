using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI; // Required when Using UI elements.

public class sounds : MonoBehaviour {
	public Dropdown drop;
	public Text selectedName;

	public void dropdown_indexChanged(int index){
		if (index == 0 )
			PlayerPrefs.SetInt ("sound", 0);
		if (index == 1)
			PlayerPrefs.SetInt ("sound", 0);
		if (index == 2)
			PlayerPrefs.SetInt ("sound", 1);
	}
}
