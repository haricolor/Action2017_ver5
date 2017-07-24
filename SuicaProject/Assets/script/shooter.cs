using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Shot(transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	protected void Shot(Transform origin)
	{
		Instantiate(bullet, origin.position, origin.rotation);
	}
}
