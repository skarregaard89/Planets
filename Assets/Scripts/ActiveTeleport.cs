// Written by Nikolaj Thomsen

using UnityEngine;

using System.Collections;

public class ActiveTeleport : MonoBehaviour {
	
	public Transform teleportSound;
	public static int active = 0;
	public Transform teleportExit;
	public Transform cube;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(active >= 1 && other.gameObject.name == "Capsule")
		{
			Instantiate(teleportSound, Camera.main.transform.position, Quaternion.identity);
			Destroy(other.gameObject);
			Instantiate(cube, teleportExit.transform.position, cube.rotation);
			active = 0;
		}
	}
}
