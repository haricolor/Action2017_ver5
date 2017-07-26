using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	public int speed = 10;
	public float StageScaleMaxX;
	public float StageScaleMinX;
	public float StageScaleMaxY;
	public float StageScaleMinY;

	void Start ()
	{
		Vector3 target = GameObject.FindGameObjectWithTag("enemy").transform.position;
		transform.up = target;
		Debug.Log (target.x);
		Vector3 angle = target - transform.position;
		angle = angle.normalized;
		GetComponent<Rigidbody2D>().velocity = angle * speed;
	}

	void Update () {
		if (transform.position.x >= StageScaleMaxX || transform.position.x <= StageScaleMinX || transform.position.y >= StageScaleMaxY || transform.position.y <= StageScaleMinY) {
			Destroy (this.gameObject);
		}

	}
}
