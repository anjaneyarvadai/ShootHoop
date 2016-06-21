using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {
	ScoreAbsorber scoreabsorber;
	Text text;
	int highscore;

	// Use this for initialization
	void Start () {
		scoreabsorber = FindObjectOfType<ScoreAbsorber>();
		highscore = PlayerPrefs.GetInt ("highscore", highscore);
		Debug.Log("High score is "+ highscore);
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Score : "+scoreabsorber.score;
	
	}
}
