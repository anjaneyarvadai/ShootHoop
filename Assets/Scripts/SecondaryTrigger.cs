using UnityEngine;
using System.Collections;

public class SecondaryTrigger : MonoBehaviour {
	Collider expectedCollider;
	public int increment = 1;

	public void ExpectCollider(Collider collider) {
		expectedCollider = collider;
	}

	void OnTriggerEnter(Collider otherCollider) {
		if (otherCollider == expectedCollider) {
			ScoreKeep scorekeep = FindObjectOfType<ScoreKeep>();
			scorekeep.IncrementScore(increment);
		}
	}
}
