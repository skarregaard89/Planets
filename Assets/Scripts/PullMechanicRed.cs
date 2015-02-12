// Written by Nikolaj Thomsen

using UnityEngine;
using System.Collections;

public class PullMechanicRed : MonoBehaviour {

	GameObject center; 
	float gravity = 50;
	
	
	void Start(){
		
	}
	
	void Update (){
		
		
	
		Vector3 diff = new Vector3(14.51806f,0,0) - transform.position;
			
		rigidbody.AddForce(diff * Time.deltaTime * gravity);
		
		
	}
}
