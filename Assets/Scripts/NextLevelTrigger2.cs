﻿// Written by Nikolaj Thomsen 

using UnityEngine;
using System.Collections;

public class NextLevelTrigger2 : MonoBehaviour
{

	
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnCollisionEnter (Collision other)
	{	
		if (other.gameObject.name == "Ove") {
			Application.LoadLevel("Level3");
		}
	}
}
