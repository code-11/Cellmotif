using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{

	private bool isPlayingSound = false;
	public GameObject m_target;
	public float m_speed = 5;
	public Sprite highlighted;
	public Sprite normal;
	private SpriteRenderer Srenderer;

	IEnumerator playSound ()
	{	
		isPlayingSound = true;
		yield return new WaitForSeconds (3f);
		isPlayingSound = false;
		audio.Play ();
		Debug.Log ("Play Sound");
	}

	/*IEnumerator pulse(){
		if (Srenderer.sprite == normal) {
						Srenderer.sprite = highlighted;
				}
		else {
						Srenderer.sprite = normal;
				}

		}*/

	// Use this for initialization
	void Start ()
	{
		Srenderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!isPlayingSound) {
			StartCoroutine (playSound());
			//StartCoroutine (pulse());
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
