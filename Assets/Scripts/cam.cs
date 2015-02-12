// Written by Martin Skarregaard

using UnityEngine;
using System.Collections;

public class cam : MonoBehaviour {
	public AudioSource m5;

	public Transform viewAt;
	public float rotateSpeed = 20.555f;
	
	public GameObject carl;
	public GameObject ove;
	public GameObject bluePlanet;
	
	private bool startTrue = true;
	private bool start2True = true;
	private bool start3True = true;
	private bool textTrue = true;
	public static bool cutScene = false;
	
	public Transform startText1;
	public Transform startText2;
	public Transform text;	
	
	public float startTimer = 0.0f;
	public float start2Timer = 0.0f;
	public float start3Timer = 0.0f;
	public float timer = 0.0f;

	// Use this for initialization
	void Start () {
		m5 = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClip5;
		myAudioClip5 = (AudioClip)Resources.Load ("attention");
		m5.clip = myAudioClip5;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		
		if (startTrue)
		{
			startTimer += Time.deltaTime;
			print ("startTimer "+startTimer);
			if (startTimer > 1)
				Instantiate(startText1, new Vector3(bluePlanet.transform.position.x,bluePlanet.transform.position.y,bluePlanet.transform.position.z), text.rotation);
			if (startTimer > 1)
    			startTrue = false;
		}
		
		if (start2True)
			{
			start2Timer += Time.deltaTime;
			if (start2Timer > 4)
				Instantiate(startText2, new Vector3(bluePlanet.transform.position.x,bluePlanet.transform.position.y,bluePlanet.transform.position.z), text.rotation);
    		if (start2Timer > 4)
				start2True = false;
		}
		if (cutScene == true)
			{
				start3Timer += Time.deltaTime;
			}
		
		transform.LookAt(viewAt);
		if((carl.transform.position.x  - ove.transform.position.x < 1 && carl.transform.position.x  - ove.transform.position.x > -1) &&( carl.transform.position.y  - ove.transform.position.y < 1 && carl.transform.position.y  - ove.transform.position.y > -1) )
		{
			if (textTrue)
			{
				Instantiate(text, new Vector3(carl.transform.position.x,carl.transform.position.y,carl.transform.position.z), text.rotation);
				textTrue = false;
				cutScene = true;
				m5.Play ();
			}
		
			
		}
		
			if (cutScene)
			{
				timer += Time.deltaTime;
				if (timer > 5)
    			rigidbody.AddForce(new Vector3(1 + rotateSpeed,0,1 + rotateSpeed));
			}
		if (start3Timer >= 16.6f)
		{
			Application.LoadLevel("Level1");
			cutScene = false;
		}
					
		
		
	}
	
}	
