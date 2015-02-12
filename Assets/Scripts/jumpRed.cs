// Written by Troels Hagensen

using UnityEngine;
using System.Collections;

public class jumpRed : MonoBehaviour {
	//is actually superjump
	public AudioSource jump1;

	// Use this for initialization
	void Start () {
		jump1 = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClip6;
		myAudioClip6 = (AudioClip)Resources.Load ("powerjump1");
		jump1.clip = myAudioClip6;
		jump1.Play ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
}
