using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

        this.transform.SetParent(UnityEngine.Object.FindObjectOfType<Canvas>().transform);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDestroy()
    {
        Destroy(this.gameObject);
    }
}
