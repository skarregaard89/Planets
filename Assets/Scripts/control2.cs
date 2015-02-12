// Written by Nikolaj Thomsen

using UnityEngine;
using System.Collections;

public class control2 : MonoBehaviour {

	public GameObject center2;
	public Transform jump;
	public float right;
	public float left;
	public float gravity;
	public static bool ground;
	

	// Update is called once per frame
	void FixedUpdate () 
	{
			
		Vector3 diff = center2.transform.position - transform.position;
			
		rigidbody.AddForce(diff * Time.deltaTime * gravity);
		
		if (Input.GetButton ("Left2"))
		{
			transform.RotateAround(center2.transform.position, Vector3.forward, left);
			
		}
		if (Input.GetButton ("Right2"))
		{
		transform.RotateAround(center2.transform.position, Vector3.forward, right);
		}
		
		if (Input.GetKeyDown ("up") && ground == true )
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
		if (other.transform.tag == "Ground2")
		{
			ground = true;
		}
	}
}
