using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	public float speed = 0.05f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 target = GameObject.FindGameObjectWithTag("enemy").transform.position;
		Debug.Log (target.x);
		Vector3 angle = target - transform.position;
		angle = angle.normalized;
		transform.position = transform.position + (angle * speed);
	}
}