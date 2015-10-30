using UnityEngine;
using System.Collections;
//Dylan Waij

public class Instructions : MonoBehaviour {

	public GUISkin guiskin;

	void OnGUI(){
		GUI.Box (new Rect (Screen.width * 0.32f, Screen.height * 0.08f, 575, 575), "Instructions");
		GUI.Label (new Rect (Screen.width * 0.42f,Screen.height * 0.21f,Screen.width * 0.2f,Screen.height * 0.1f), "Left arrow moves the left flipper and right arrow moves the right one.");
		GUI.Label (new Rect (Screen.width * 0.42f, Screen.height * 0.27f, Screen.width * 0.2f, Screen.height * 0.1f), "F1 to F4 Allows you to swap between camera's to give you a better view of the map.");
		GUI.Label (new Rect (Screen.width * 0.42f, Screen.height * 0.33f, Screen.width * 0.2f, Screen.height * 0.1f), "It also gives a bit of diversity to the game.");
		if (GUI.Button (new Rect (Screen.width * 0.42f, Screen.height * 0.7f, Screen.width * 0.2f, Screen.height * 0.1f), "Main Menu")) {
			Application.LoadLevel ("MainMenu");
		}
		
	}
}
