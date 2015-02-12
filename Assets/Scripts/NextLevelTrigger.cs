// Written by Nikolaj Thomsen

using UnityEngine;
using System.Collections;

public class NextLevelTrigger : MonoBehaviour {
	
	
	
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
		Application.LoadLevel("Level2");
		
		}
	}
}
