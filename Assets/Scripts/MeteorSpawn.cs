// Written by Anders Olsen

using UnityEngine;
using System.Collections;

public class MeteorSpawn : MonoBehaviour {
	
	
	public Transform pivot;
	public Transform meteor;
	uint count = 1;
	float randTime;
	float timer = 0;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this.gameObject);
		randTime = Random.Range(2,5);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		transform.RotateAround(pivot.transform.position	, Vector3.forward, 5 * Time.deltaTime * 2);
		if(timer > randTime*count)
		{
			randTime = Random.Range(1, 2);
			int random = Random.Range(0,7);
			count+=2;
			if(random == 0)
			{
				Instantiate(meteor, transform.position, Quaternion.identity);	
			}
		}
	}
}