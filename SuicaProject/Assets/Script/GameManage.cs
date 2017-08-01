using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour {

    //オブジェクト読み込みエリア
    public GameObject Player;
    public GameObject HPbar;
    public GameObject back;

    //



    //変数宣言エリア
    public bool GamePlay = false;
    public bool GameOver = false;
    //

    // Use this for initialization
    void Start () {
        //タイトルの表示



        //ゲームスタート
        Game_Start();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Title() {


    }

    void Game_Start() {

        enemyPop En = GetComponent<enemyPop>();

        En.StartPop();

        Instantiate(Player, new Vector3(0, 0, 0), Quaternion.identity);

        Instantiate(HPbar, new Vector3(300, 500, 0), Quaternion.identity);

        Instantiate(back, new Vector3(0, 0, 0), Quaternion.identity);

        GamePlay = true;

        //while(GamePlay){
        //    if (GameOver) {
        //        GamePlay = false;
        //        Resalt();
        //        return;
        //    }
        //}

    }

    void Resalt() {

        Rnaking Rn = GetComponent<Rnaking>();

        Rn.Resalt_Open();

        //while (GameOver) {
        //    if (GamePlay) {
        //        GameOver = false;
        //        Game_Start();
        //        return;
        //    }
        //}

    }
}
