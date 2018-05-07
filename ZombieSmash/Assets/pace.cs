using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI; // Required when Using UI elements.

public class pace : MonoBehaviour
{
	
	public Dropdown drop;
	public Text selectedName;

	public void dropdown_indexChanged(int index){
		if (index == 0 )
			PlayerPrefs.SetFloat ("speed", 10.0f);
		if (index == 1)
			PlayerPrefs.SetFloat ("speed", 10.0f);
		if (index == 2)
			PlayerPrefs.SetFloat ("speed", 16.0f);
	}
}