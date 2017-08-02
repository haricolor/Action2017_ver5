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

    private GameObject N1;
    private GameObject N2;
    private GameObject N3;
    private GameObject N4;
    private GameObject N5;
    private GameObject N6;
    private GameObject N7;
    private GameObject N8;
    private GameObject N9;

    private GameObject yourScore;
    private GameObject YS;

    private GameObject restartButton;
    private GameObject RS;

    public int[] score = { 0, 0, 0, 0, 0, 0, 0, 0, 0};

    public string[] NAME = { "", "", "", "", "", "", "", "", ""};

    public int Plyer_Score;

    public string Player_name;

    public int Player_Rank;

    public int pool1;
    public int pool2;


    // Use this for initialization
    public void Resalt_Open () {

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

        GameObject yourScore = Instantiate(YourScore, new Vector3(230, 300, 0), Quaternion.identity);

        YS = yourScore;

        GameObject restartButton = Instantiate(RestartButton, new Vector3(230, 100, 0), Quaternion.identity);

        RS = restartButton;

        GameObject No1 = Instantiate(no1, new Vector3(740, 40 + 54 * 8, 0), Quaternion.identity);
        GameObject No2 = Instantiate(no2, new Vector3(740, 40 + 54 * 7, 0), Quaternion.identity);
        GameObject No3 = Instantiate(no3, new Vector3(740, 40 + 54 * 6, 0), Quaternion.identity);
        GameObject No4 = Instantiate(no4, new Vector3(740, 40 + 54 * 5, 0), Quaternion.identity);
        GameObject No5 = Instantiate(no5, new Vector3(740, 40 + 54 * 4, 0), Quaternion.identity);
        GameObject No6 = Instantiate(no6, new Vector3(740, 40 + 54 * 3, 0), Quaternion.identity);
        GameObject No7 = Instantiate(no7, new Vector3(740, 40 + 54 * 2, 0), Quaternion.identity);
        GameObject No8 = Instantiate(no8, new Vector3(740, 40 + 54 * 1, 0), Quaternion.identity);
        GameObject No9 = Instantiate(no9, new Vector3(740, 40 + 54 * 0, 0), Quaternion.identity);

        N1 = No1;
        N2 = No2;
        N3 = No3;
        N4 = No4;
        N5 = No5;
        N6 = No6;
        N7 = No7;
        N8 = No8;
        N9 = No9;

    }

    public void NameInput() {
        NAME[Player_Rank] = Player_name;
    }

    public void OnDestroy()
    {
        //Destroy(N1);
        //Destroy(N2);
        //Destroy(N3);
        //Destroy(N4);
        //Destroy(N5);
        //Destroy(N6);
        //Destroy(N7);
        //Destroy(N8);
        //Destroy(N9);
        //Destroy(YS);
        //Destroy(RS);
    }

    // Update is called once per frame
    void Update () {

	}

    void Start()
    {
    
    }
}

