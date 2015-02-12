// Written by Anders Olsen

using UnityEngine;
using System.Collections;

public class Meteor2 : MonoBehaviour {
	
	//public Transform pivot;
	float moveSpeed = 0.5f;
	public Transform exp;
	float timer;
	float timer2;
	bool hit = false;
	public Transform fire;
	public Transform sound;
	public AudioSource m1;
	public AudioSource m2;
	public AudioSource m3;
	public AudioSource m4;
	AudioSource[] mArr = new AudioSource[4];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(hit)
			timer2 += Time.deltaTime;
		if(timer2 > 3)
			Destroy(gameObject);
		
		Instantiate(fire, transform.position, Quaternion.identity);
		timer += Time.deltaTime;
			
		Vector3 diff = new Vector3(-15.16323f,0,0) - transform.position;
			
		rigidbody.AddForce(diff * Time.deltaTime * moveSpeed);
		if(timer > 10)
		{
			Instantiate(exp, transform.position, Quaternion.identity);
		}
	}
	
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name != "Meteor(Clone)")
		{
			if(other.gameObject.tag == "Player")
				Score.score -= 500;
			Instantiate(exp, transform.position, Quaternion.identity);
			hit = true;
			Instantiate(sound, Camera.main.transform.position, Quaternion.identity);
			gameObject.transform.position = new Vector3(-15.16323f,0,10);
		}
	}
}