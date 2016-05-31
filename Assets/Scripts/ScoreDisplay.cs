using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
	TextMesh text;
	ScoreKeep scorekeep;

	// Use this for initialization
	void Start () {
		scorekeep = FindObjectOfType<ScoreKeep>();
		text = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Score: "+scorekeep.score;
	}
}
