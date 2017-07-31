using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus : MonoBehaviour {

	public float speed = -0.05f;
	public float StageScaleMaxX;
	public float StageScaleMinX;
	public float StageScaleMaxY;
	public float StageScaleMinY;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x >= StageScaleMaxX || transform.position.x <= StageScaleMinX || transform.position.y >= StageScaleMaxY || transform.position.y <= StageScaleMinY) {
			Destroy (this.gameObject);
		}
		Move ();

	}

	private void Move () {
		Vector3 target = GameObject.FindGameObjectWithTag("Player").transform.position;
		Vector3 angle = target - transform.position;
		angle = angle.normalized;
		transform.position = transform.position + (angle * speed);
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Player") {
			Destroy (gameObject);
		} else if (coll.gameObject.tag == "Weapon") {
			Score_Manager.ScoreTotal += 3;
			Destroy (gameObject);
		}
	}
}
