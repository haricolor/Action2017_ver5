using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rnaking : MonoBehaviour {

    public GameObject Score_Manager;

    public GameObject YourScore;

    public GameObject RestartButton;

    public GameObject no1;
    public GameObject no2;
    public GameObject no3;
    public GameObject no4;
    public GameObject no5;
    public GameObject no6;
    public GameObject no7;
    public GameObject no8;
    public GameObject no9;

    public int[] score = { 0, 0, 0, 0, 0, 0, 0, 0, 0};

    public string[] NAME = { "", "", "", "", "", "", "", "", ""};

    public int Plyer_Score;

    public string Player_name;

    public int Player_Rank;

    public int pool1;
    public int pool2;


    // Use this for initialization
    void Start () {

        //for (int i = 0;i < 9;i++) {
        //    if (score[i] < Plyer_Score) {
        //        for(int j = 8;j > i; j--){
        //          score[j] = score[j - 1];
        //          NAME[j] = NAME[j - 1];
        //        }
        //        score[i] = Plyer_Score;
        //        NAME[i] = Player_name;
        //        Player_Rank = i;
        //        break;
        //    }
        //}

        Instantiate(YourScore, new Vector3(230, 300, 0), Quaternion.identity);

        Instantiate(RestartButton, new Vector3(230, 100, 0), Quaternion.identity);

        Instantiate(no1, new Vector3(740, 40 + 54 * 8, 0), Quaternion.identity);
        Instantiate(no2, new Vector3(740, 40 + 54 * 7, 0), Quaternion.identity);
        Instantiate(no3, new Vector3(740, 40 + 54 * 6, 0), Quaternion.identity);
        Instantiate(no4, new Vector3(740, 40 + 54 * 5, 0), Quaternion.identity);
        Instantiate(no5, new Vector3(740, 40 + 54 * 4, 0), Quaternion.identity);
        Instantiate(no6, new Vector3(740, 40 + 54 * 3, 0), Quaternion.identity);
        Instantiate(no7, new Vector3(740, 40 + 54 * 2, 0), Quaternion.identity);
        Instantiate(no8, new Vector3(740, 40 + 54 * 1, 0), Quaternion.identity);
        Instantiate(no9, new Vector3(740, 40 + 54 * 0, 0), Quaternion.identity);
    }

    public void NameInput() {
        NAME[Player_Rank] = Player_name;
    }
	
	// Update is called once per frame
	void Update () {

	}
}

