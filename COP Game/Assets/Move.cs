using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	private Rigidbody2D rb;
	private bool rigid = false; 
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();	
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (!rigid) {
			float h = Input.GetAxis ("Horizontal") * 10;
			Vector2 vel = rb.velocity;
			vel.x = h;
			rb.velocity = vel;
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
			rigid = true;
	}
}
