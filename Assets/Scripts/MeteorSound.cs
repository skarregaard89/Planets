// Written by Anders Olsen

using UnityEngine;
using System.Collections;

public class MeteorSound : MonoBehaviour {
	
	public AudioSource m1;
	public AudioSource m2;
	public AudioSource m3;
	public AudioSource m4;
	AudioSource[] mArr = new AudioSource[4];
	
	public float timer = 0;

	// Use this for initialization
	void Start () {
		m1 = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClip;
		myAudioClip = (AudioClip)Resources.Load ("meteor1");
		m1.clip = myAudioClip;
		
		m2 = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClip2;
		myAudioClip2 = (AudioClip)Resources.Load ("meteor2");
		m2.clip = myAudioClip2;
		
		m3 = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClip3;
		myAudioClip3 = (AudioClip)Resources.Load ("meteor3");
		m3.clip = myAudioClip3;
		
		m4 = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClip4;
		myAudioClip4 = (AudioClip)Resources.Load ("meteor4");
		m4.clip = myAudioClip4;
		
		mArr[0] = m1;
		mArr[1] = m2;
		mArr[2] = m3;
		mArr[3] = m4;
		
		for(int i = 0; i < 4; i++)
			mArr[i].volume = 1;
		
		mArr[Random.Range(0,4)].Play();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer > 4)
			Destroy(gameObject);
	}
}
