using UnityEngine;
using System.Collections;

public class absorbController : MonoBehaviour {

	public float m_growFactor = 1.5f ;

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D hit){
		Debug.Log ("Hit");
		Destroy (hit.gameObject);
		gameObject.transform.localScale = gameObject.transform.localScale * m_growFactor;
	}

	// Update is called once per frame
	void Update () {

	}
}
