// Written by Anders Olsen

using UnityEngine;
using System.Collections;

public class Teleport2 : MonoBehaviour
{
	public Transform teleportSound;
	public Transform teleportExit;
	public Transform sphere;
	public Transform cube;
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	void OnTriggerEnter (Collider other)
	{
		 
		if (other.gameObject.name == "Crate") {
			Instantiate(teleportSound, Camera.main.transform.position, Quaternion.identity);
			Destroy (other.gameObject);
			Instantiate (cube, teleportExit.transform.position, Quaternion.identity);
			teleportExit.transform.position = new Vector3 (23.25848f, 10.54819f, 0);
		}
		
		/*if (other.gameObject.name == "Sphere") {
			Destroy (other.gameObject);
			Instantiate (sphere, teleportExit.transform.position, Quaternion.identity);
			teleportExit.transform.position = new Vector3 (0, -10, 0);
		}*/
		
	}
}
