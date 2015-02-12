// Written by Nikolaj Thomsen

using UnityEngine;
using System.Collections;

public class SpotLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		light.color = Color.black;
		if (ActiveTeleport.active == 1)
			light.color = Color.red;
	
	}
}
