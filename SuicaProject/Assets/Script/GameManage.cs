using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour {

    //オブジェクト読み込みエリア
    public GameObject Player;
    public GameObject HPbar;
    public GameObject back;
    public GameObject title;
    //

    //BGM関連
    public AudioClip BGM;
    private AudioSource audioSource;
    //

    //変数宣言エリア
    public bool GamePlay = false;
    public bool GameOver = false;
    //

    // Use this for initialization
    void Start () {

        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = BGM;

        GetComponent<enemyPop>().enabled = true;

        //タイトルの表示
        Title();


        //ゲームスタート
        //Game_Start();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Title() {

        Instantiate(title, new Vector3(500, 300, 0), Quaternion.identity);

    }

    public void Game_Start() {

        enemyPop En = GetComponent<enemyPop>();

        En.StartPop();

        Instantiate(Player, new Vector3(0, 0, 0), Quaternion.identity);

        Instantiate(HPbar, new Vector3(350, 500, 0), Quaternion.identity);

        Instantiate(back, new Vector3(0, 0, 0), Quaternion.identity);

        //audioSource.Play();

        GamePlay = true;

        //while(GamePlay){
        //    if (GameOver) {
        //        GamePlay = false;
        //        Resalt();
        //        return;
        //    }
        //}

    }

    public void Game_ReStart() {

        Player PL = Player.GetComponent<Player>();

        PL.HPmax();

        enemyPop En = GetComponent<enemyPop>();

        En.StartPop();

        Instantiate(Player, new Vector3(0, 0, 0), Quaternion.identity);

        Instantiate(HPbar, new Vector3(350, 0, 0), Quaternion.identity);

    }

    public void Resalt() {

        //audioSource.Stop();

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
