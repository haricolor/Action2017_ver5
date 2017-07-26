using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {

	public GameObject bullet;
	public float shotDelay;

	// Startメソッドをコルーチンとして呼び出す
	IEnumerator Start ()
	{
		while (true) {
			// 弾をプレイヤーと同じ位置/角度で作成
			Instantiate (bullet, transform.position, transform.rotation);
			// 0.05秒待つ
			yield return new WaitForSeconds (shotDelay);
		}
	}


}
