using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour {
	Spawner spawn;
	// Use this for initialization
	public void CallSpawner () {
		GameObject scoreObject = GameObject.FindWithTag ("Respawn");
		if (scoreObject != null) {
			spawn = scoreObject.GetComponent<Spawner> ();
		} else
			spawn = null;
		spawn.Play ();
		Destroy (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
