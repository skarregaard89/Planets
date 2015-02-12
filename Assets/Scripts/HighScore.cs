//Written by Martin Skarregaard

using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour
{
	
	public static int isShown = 0;
	int highscore = 0;
	
	bool shownScore = true;
	
	// Use this for initialization
	void Start ()
	{
		DontDestroyOnLoad (this.gameObject);
		
		if (Score.score > highscore)
			highscore = Score.score;
		
		
		if (shownScore)
		GetComponent<TextMesh> ().text = "HIGHEST SCORE - - - " + highscore;
		GetComponent<TextMesh> ().fontSize = 50;
		GetComponent<TextMesh> ().anchor = TextAnchor.MiddleCenter;
		Score.kill = 1;
		shownScore = false;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetComponent<TextMesh> ().transform.position = new Vector3 (-10 + (1000 * isShown), 5 + (1000 * isShown), 0);
	}
}