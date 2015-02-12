// Written by Anders Olsen

using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	
	public Transform teleportExit;
	public Transform teleportSound;
	//public Transform sphere;
	public Transform cube;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Crate" || other.gameObject.name == "CrateRed(Clone)" ||other.gameObject.name == "Crate(Clone)")
		{
			Instantiate(teleportSound, Camera.main.transform.position, Quaternion.identity);
			Destroy(other.gameObject);
			Instantiate(cube, teleportExit.transform.position, Quaternion.identity);
		}
		
		/*if(other.gameObject.name == "Sphere")
		{
			Destroy(other.gameObject);
			Instantiate(sphere, teleportExit.transform.position, Quaternion.identity);
		}*/
	}
}
