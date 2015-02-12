// Written by Troels Hagensen

using UnityEngine;
using System.Collections;

public class teleSound : MonoBehaviour {
	public AudioSource tSound;

	// Use this for initialization
	void Start () {
		tSound = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClip7;
		myAudioClip7 = (AudioClip)Resources.Load ("teleportUd");
		tSound.clip = myAudioClip7;
		tSound.Play ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
}
