using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{

	private bool isPlayingSound = false;
	public GameObject m_target;
	public float m_speed = 5;

	IEnumerator playSound ()
	{
		isPlayingSound = true;
		yield return new WaitForSeconds (3f);
		isPlayingSound = false;
		audio.Play ();
		Debug.Log ("Play Sound");
	}

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!isPlayingSound) {
			StartCoroutine (playSound ());
		}
		moveToTarget ();
	}
	void moveToTarget ()
	{
		Vector2 dif = m_target.transform.position - transform.position;
		if ((dif).magnitude > 1) {
			rigidbody2D.AddForce (dif * m_speed);
		}
	}
}
