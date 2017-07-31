using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour {

    public GameObject Player;

    public GameObject HPbar;

    public static bool gameStart;

    // Use this for initialization
    void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameStart == true || Input.GetKeyDown(KeyCode.A)) {
            Instantiate(Player, new Vector3(0, 0, 0), Quaternion.identity);

            Instantiate(HPbar, new Vector3(0, 0, 0), Quaternion.identity);
        }
	}
}
