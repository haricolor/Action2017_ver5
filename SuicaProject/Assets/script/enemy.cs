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
		Move ();
	}

	void Move(){
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
			Score_Manager.ScoreTotal += 1;
			Destroy (gameObject);
		}
	}
}