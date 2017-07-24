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
		move ();

	}

	private void move () {
		Vector3 target = GameObject.FindGameObjectWithTag("enemy").transform.position;
		Debug.Log (target.x);
		Vector3 angle = target - transform.position;
		angle = angle.normalized;
		transform.position = transform.position + (angle * speed);
	}
}
