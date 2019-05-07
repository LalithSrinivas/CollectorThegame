using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour {
	Score_Script scoreScript;
	// Use this for initialization
	void Start () {
		GameObject scoreObject = GameObject.FindWithTag ("GameController");
		if (scoreObject != null) {
			scoreScript = scoreObject.GetComponent<Score_Script> ();
		} else
			scoreScript = null;
	}

void OnCollisionEnter2D(Collision2D coll)
	{
		if (Check(coll.collider.name))
		scoreScript.AddScore(0, 0, 1);
	}

bool Check(string.name){
	if (gameObject.name == "Green_bin") then{
		return false;
	else{
		if (gameObject.name == "Blue_bin") then
			return false;
		else{
			if (gameObject.name == "ground") then
				return false;
			else
				return true;
			}
		}
	}
}