using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {
	public int scoreperhit = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		ScoreKeep scorekeep = FindObjectOfType<ScoreKeep>();
		scorekeep.IncrementScore(scoreperhit);
	}
}
