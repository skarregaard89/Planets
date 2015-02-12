// Written by Nikolaj Thomsen 

using UnityEngine;
using System.Collections;

public class SuperJump : MonoBehaviour {
	
	public Transform sJump;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.name == "Carl" && Input.GetKeyDown("w"))
		{
			Controls.gravity = -30000;
			Instantiate(sJump, Camera.main.transform.position, Quaternion.identity);
		}
	}
}
