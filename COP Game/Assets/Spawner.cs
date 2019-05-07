using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] objects;
	int randomObject;
	int count = 20;
	// Use this for initialization
	public void Play () {
		randomObject = Random.Range (0, objects.Length);
		InvokeRepeating ("Spawn", 0.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Spawn () {
		if (count != 0) {
			randomObject = Random.Range (0, objects.Length);
			Instantiate (objects [randomObject]);
			count--;
		}
	}
}
