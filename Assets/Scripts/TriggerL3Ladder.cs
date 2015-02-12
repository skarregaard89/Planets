// Written by Nikolaj Thomsen

using UnityEngine;
using System.Collections;

public class TriggerL3Ladder : MonoBehaviour {

	public Transform ladder;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Ove")
		Instantiate (ladder, new Vector3 (-26.31603f, 11.5055f, 0),ladder.rotation);
	}
}
