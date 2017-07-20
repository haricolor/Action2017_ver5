using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour {
    void Update()
    {

        Set_position();
        Attack();

    }

    public void Set_position()
    {

        Vector3 PlayerPosition = GameObject.Find("Player").transform.position; //プレイヤーのポジションを取得
        Vector3 PlayerScale = GameObject.Find("Player").transform.localScale; //プレイヤーのスケールを取得
        Vector3 WeaponScale = transform.localScale; //武器のスケールを取得

        if (PlayerScale.x < 0)
        {
            WeaponScale.x = -2; //武器を左向きに

            //プレイヤーに合わせて武器も移動
            GameObject.Find("PlayerWeapon").transform.position = new Vector2(PlayerPosition.x - 1, PlayerPosition.y);
        }
        if (PlayerScale.x > 0)
        {
            WeaponScale.x = 2; //武器を右向きに

            //プレイヤーに合わせて武器も移動
            GameObject.Find("PlayerWeapon").transform.position = new Vector2(PlayerPosition.x + 1, PlayerPosition.y);
        }
        transform.localScale = WeaponScale;
    }

    public void Attack()
    {

        //アニメーションを再生
        if (Input.GetKey(KeyCode.Space))
        {

        }
    }
}
