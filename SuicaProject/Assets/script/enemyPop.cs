using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPop : MonoBehaviour {

    //生まれてくる敵プレハブ
    public GameObject suicaNormal;
    public GameObject suicaRed;
    public GameObject suicaShooter;
    public GameObject suicaBonus;
    //敵を格納
    GameObject[] existEnemys;


    //アクティブ最大数
    public int maxEnemy = 10;



    // Use this for initialization
    public void StartPop()
    {
        //配列確保
        existEnemys = new GameObject[maxEnemy];

        //周期的に実行したい場合はコルーチン
        StartCoroutine(Exec());

    }

    //敵を作成する
    IEnumerator Exec()
    {
        while (true)
        {
            Generate();
            yield return new WaitForSeconds(3.0f);
        }
    }

    void Generate()
    {
        for (int enemyCount = 0; enemyCount < existEnemys.Length; ++enemyCount)
        {
            if (existEnemys[enemyCount] == null)
            {
                //敵の座標
                float x = Random.Range(-4f, 4f);
                float y = Random.Range(-4f, 4f);

                //敵を作成する
                if (enemyCount >= 10 && enemyCount % 10 == 0)
                {
                    existEnemys[enemyCount] = Instantiate(suicaBonus, new Vector2(x, y), transform.rotation) as GameObject;
                    return;
                }
                else if (enemyCount >= 5 && enemyCount % 5 == 0)
                {
                    existEnemys[enemyCount] = Instantiate(suicaRed, new Vector2(x, y), transform.rotation) as GameObject;
                    return;
                }
                else if (enemyCount > 3 && enemyCount % 2 != 0)
                {
                    existEnemys[enemyCount] = Instantiate(suicaShooter, new Vector2(x, y), transform.rotation) as GameObject;
                    return;
                }
                else
                {
                    existEnemys[enemyCount] = Instantiate(suicaNormal, new Vector2(x, y), transform.rotation) as GameObject;
                    return;
                }
            }
        }
    }



}
