using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yourScore : MonoBehaviour {

    public GameObject Ranking;

    private int yScore;

    public Text score;

    public new InputField name;

	// Use this for initialization
	void Start () {

        this.transform.SetParent(UnityEngine.Object.FindObjectOfType<Canvas>().transform);

        Rnaking Rn = Ranking.GetComponent<Rnaking>();

        yScore = Rn.Plyer_Score;

        score.text = yScore + "点です";

        this.transform.SetParent(UnityEngine.Object.FindObjectOfType<Canvas>().transform);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDestroy()
    {
        Destroy(this.gameObject);
    }

}
