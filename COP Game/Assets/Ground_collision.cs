using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_collision : MonoBehaviour {

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
		scoreScript.AddScore (-2, 0, 1);

	}

}
