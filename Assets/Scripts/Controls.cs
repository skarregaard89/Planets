// Written by Nikolaj Thomsen

using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	
	public GameObject center;
	public Transform jump;
	public float right;
	public float left;
	public static float gravity;
	public static bool ground;


	// Update is called once per frame
	void FixedUpdate () 
	{
		
		
			
		Vector3 diff = center.transform.position - transform.position;
			
		rigidbody.AddForce(diff * Time.deltaTime * gravity);
		
		if (Input.GetButton ("Left"))
		{
			transform.RotateAround(center.transform.position, Vector3.forward, left);
			
		}
		if (Input.GetButton ("Right"))
		{
		transform.RotateAround(center.transform.position, Vector3.forward, right);
		}
		
		if (Input.GetKeyDown("w") && ground == true )
		{
			Instantiate(jump, Camera.main.transform.position, Quaternion.identity);
			gravity = -12000;
			ground = false;
			
		}
		else 
		{
			gravity = 500;
		}
		
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.transform.tag == "Ground" || other.transform.tag == "Jelly")
		{
			ground = true;
		}
	}
}
