using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {
	ScoreAbsorber scoreabsorber;
	Text text;

	// Use this for initialization
	void Start () {
		scoreabsorber = FindObjectOfType<ScoreAbsorber>();
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score : "+scoreabsorber.score;
	
	}
}
