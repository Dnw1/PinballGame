using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//Soufyan Hassan

public class ScoreDisplay : MonoBehaviour 
{
	public static int score = 0;
	
	void OnGUI()
	{
		GUILayout.Label("Score: " + score.ToString());
	}
}
