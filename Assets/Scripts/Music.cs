// Written by Nikolaj Thomsen

using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	
	public AudioSource backMusic;

	// Use this for initialization
	void Start () {
		backMusic = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClip;
		myAudioClip = (AudioClip)Resources.Load ("Space Song Loop");
		backMusic.clip = myAudioClip;
		backMusic.volume = 0.3f;
		backMusic.loop = true;
		backMusic.Play();
		
	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad(this.gameObject);
	}
}
