using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public float timeTillNextLevel = 0.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(timeTillNextLevel>0){
			timeTillNextLevel -= Time.deltaTime;
			if(timeTillNextLevel < 0){
				LoadNextScene();
			}	
		}

	}

	public void LoadNextScene() {
		// Load scene
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		//currentIndex+1
		SceneManager.LoadScene(currentIndex+1);
	}

	public void LoadPrevScene() {
		// Load scene
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		//currentIndex+1
		SceneManager.LoadScene(currentIndex-1);
	}
}
