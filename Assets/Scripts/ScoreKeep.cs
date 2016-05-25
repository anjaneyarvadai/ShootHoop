using UnityEngine;
using System.Collections;

public class ScoreKeep : MonoBehaviour {

	public int score = 0;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IncrementScore(int amt) {
		score+=amt;
		print("You scored. Your current score is "+score);
	}
}
