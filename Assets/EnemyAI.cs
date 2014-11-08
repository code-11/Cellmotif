using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	private bool isPlayingSound = false;

	IEnumerator playSound(){
		isPlayingSound = true;
		yield return new WaitForSeconds(3f);
		isPlayingSound = false;
		audio.Play ();
		Debug.Log ("Play Sound");
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (!isPlayingSound) {
			StartCoroutine (playSound ());
		}
	}
}
