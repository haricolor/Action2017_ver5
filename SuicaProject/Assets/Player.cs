using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    /*public bool isGround;*/
    public float speed = 5;

    void Update()
    {
        // 右・左
        float x = Input.GetAxisRaw("Horizontal");

        // 上・下
        float y = Input.GetAxisRaw("Vertical");

        // 移動する向きを求める
        Vector2 direction = new Vector2(x, y).normalized;

        Vector3 scale = transform.localScale;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // 右方向に移動中
            scale.x = 2; // そのまま（右向き）
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 左方向に移動中
            scale.x = -2; // 反転する（左向き）
        }
        // 代入し直す
        transform.localScale = scale;


        // 移動する向きとスピードを代入する
        GetComponent<Rigidbody2D>().velocity = direction * speed;

    }
}
