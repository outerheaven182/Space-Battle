using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
	void OnGUI()
		{
			if(GUI.Button(new Rect((Screen.width/2)-75, (Screen.height/2)-50, 150,100), "PLAY"))
			Application.LoadLevel("OpeningTest");
		}
}

