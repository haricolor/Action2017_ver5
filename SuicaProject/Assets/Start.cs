using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour {

	public void OnClick()
	{
		Debug.Log("Button click!");
		// 非表示にする
		gameObject.SetActive(false);
	}

/*public class SceneLoadScript : MonoBehaviour
{
	public void SceneLoad()
	{
		Application.LoadLevel("main");
	}
}*/
}
