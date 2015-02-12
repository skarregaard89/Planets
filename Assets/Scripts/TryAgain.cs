// Written by Nikolaj Thomsen

using UnityEngine;
using System.Collections;

public class TryAgain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseOver()
	{
		if(transform.position.z <= 0 && transform.position.z >= -1 )
		{
			transform.position -= new Vector3(0,0,0.1f);
		}		
	}
	
	void OnMouseExit()
	{		
		while(transform.position.z < -0.1f)
		{
		transform.position += new Vector3(0,0,0.1f);
		}
	}
		
	void OnMouseDown()
	{
		if(gameObject.name == "Button")
	{
			HighScore.isShown = 1;
			Application.LoadLevel("mainMenu");
			
	}
			
}

}