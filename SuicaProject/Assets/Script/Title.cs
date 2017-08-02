using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour {

    public GameObject This;

    // Use this for initialization
    void Start () {
        This.transform.SetParent(UnityEngine.Object.FindObjectOfType<Canvas>().transform);
    }

    public void destroy() {

        Destroy(This);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
