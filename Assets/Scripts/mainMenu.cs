// Written by Troels Hagensen

using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {
	
	public GameObject go;
	public GameObject cont;
	public AudioSource ding;
	public Transform score;
	public float highscortTimer = 0.0f;

	
	// Use this for initialization
	void Start () {
		ding = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClip;
		myAudioClip = (AudioClip)Resources.Load ("hover");
		ding.clip = myAudioClip;
		

	
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
	void OnMouseOver()
	{
		if(transform.position.z <= 0 && transform.position.z >= -1 )
		{
			transform.position -= new Vector3(0,0,0.1f);
			ding.Play();
		}		
	}
	
	void OnMouseExit()
	{		
		while(transform.position.z < -0.1f){
		transform.position += new Vector3(0,0,0.1f);
		}
		
	}
	void OnMouseDown()
	{
		if(gameObject.name == "menuCube1")
		{
			Application.LoadLevel("Intro");
			Score.kill = 0;
			Instantiate(score, Vector3.zero, Quaternion.identity);
		}
		if(gameObject.name == "menuCube2")
		{
			go.animation.Play("Animation1");
			cont.animation.Play("Animation2");
		}
		if(gameObject.name == "menuCube3")
		{
			Application.LoadLevel("HighScore");
			HighScore.isShown = 0;
		}
		if(gameObject.name == "menuCube4")
		{
			Application.Quit();
		}
		if(gameObject.name == "menuCube5")
		{
			go.animation.Play("Animation3");
			cont.animation.Play("Animation4");
		}
		
	}
	
		
}