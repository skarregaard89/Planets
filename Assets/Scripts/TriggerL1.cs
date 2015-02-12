// Written by Nikolaj Thomsen

using UnityEngine;
using System.Collections;

public class TriggerL1 : MonoBehaviour {
	
	public GameObject box;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Ove")
		Instantiate (box, new Vector3 (-27.43128f, -2.497917f, 0),Quaternion.identity);
	}
}
