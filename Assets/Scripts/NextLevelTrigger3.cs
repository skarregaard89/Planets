// Written by Nikolaj Thomsen

using UnityEngine;
using System.Collections;

public class NextLevelTrigger3 : MonoBehaviour {

	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void OnCollisionEnter(Collision other)
	{	
		if (other.gameObject.name == "Carl"){
		HighScore.isShown = 0;
		Application.LoadLevel("HighScore");
		}
	}
}
