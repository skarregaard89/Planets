// Written by Martin Skarregaard

using UnityEngine;
using System.Collections;

public class startText : MonoBehaviour {

	public float textDuration = 4.0f;
	public float timer = 0.0f;
	

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
			timer += Time.deltaTime;
			
			if (timer >textDuration)
			Destroy(gameObject);
			
	}
}
