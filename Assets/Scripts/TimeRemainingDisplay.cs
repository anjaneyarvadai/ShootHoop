using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeRemainingDisplay : MonoBehaviour {
	TextMesh text;
	LevelManager levelManager;

	// Use this for initialization
	void Start () {
	levelManager = FindObjectOfType<LevelManager>();
		text = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Time: "+ levelManager.timeTillNextLevel;
	}
}
