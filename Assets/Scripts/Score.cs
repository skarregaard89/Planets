// Written by Mads Jøns Frausig

using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	
	public static int score;
	public static int year = 0;
	public static int kill = 0;
	public float waitingTime = 1.0f;
	public float yearTimer = 0.0f;

	
	void Start () {
			
			score = 20000;
			year = 0;
			DontDestroyOnLoad(this.gameObject);
			StartCoroutine(wait ());
			
		}
	
	void Update ()
	{
		
		if (score <= 0)
		{
			Application.LoadLevel("Dead");
			Destroy(this.gameObject);
		}
		else if(kill == 1)
		{
			Destroy(this.gameObject);
			kill=0;
		}
		
	}
	
	
	IEnumerator wait(){
			while(score > 0)
			{
			yield return new WaitForSeconds(waitingTime);
			score -= 50;
			yearTimer += 1;
			if(yearTimer == 2){
				year++;
				yearTimer = 0;
			}
			Debug.Log (year);
			Debug.Log (score);
		}
	}
	
	void OnGUI()
	{
		
		GUI.Box (new Rect (0,0,100,85),"Year: " + year + "\nScore :" + score + "\n");	
	}
	
	
}


