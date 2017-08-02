using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Get_Name : MonoBehaviour {
    new string name;

    public InputField inputField;

    public GameObject Manager;

    public void SaveText()
    {

        Rnaking Rn = Manager.GetComponent<Rnaking>();

        name = inputField.text;

        Rn.Player_name = name;

        inputField.text = "";

        Destroy(this.gameObject);

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
