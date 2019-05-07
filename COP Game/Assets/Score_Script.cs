using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Script : MonoBehaviour {
	public static int scoreValue = 0;
	public static int mistakeValue = 0;
	public static int pollutionValue = 0;
	Text score;
	// Use this for initialization
	void Start () {
		score = GetComponent<Text> ();

	}

	public void AddScore(int s, int w, int p){
		scoreValue += s;
		mistakeValue += w;
		pollutionValue += p;
		Update ();
	}

	// Update is called once per frame
	void Update () {
		score.text = "Score: " + scoreValue + "\nMismatches: " + mistakeValue + "\nPollution: " + pollutionValue;
	}
}
