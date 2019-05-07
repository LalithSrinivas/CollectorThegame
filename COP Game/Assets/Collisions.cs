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
		Destroy (coll.gameObject);
		if (Check(coll.collider.name))
			scoreScript.AddScore (2, 0, 0);
		else
			scoreScript.AddScore (-1, 1, 0);
	}
	// Update is called once per frame
	bool Check(string name) {
		if (gameObject.name == "Green_bin") {
			if (name.Contains("bio"))
				return true;
			else
				return false;
		} else {
			if (name.Contains("recycle"))
				return true;
			else
				return false;
		}
	}
}
