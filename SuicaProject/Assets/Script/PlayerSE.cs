using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSE : MonoBehaviour {

    public AudioClip swingSE;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = swingSE;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            audioSource.Play();
        }
	}
}
