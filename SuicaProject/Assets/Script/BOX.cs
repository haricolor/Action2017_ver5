using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BOX : MonoBehaviour {

    public int number;

    public Text num;

    public new Text name;

    public Text score;

    public GameObject Ranking;

    private int[] Score;

    private string[] Name;

    // Use this for initialization
    void Start () {

        this.transform.SetParent(UnityEngine.Object.FindObjectOfType<Canvas>().transform);

        num.text = "" + number;

        Rnaking Rn = Ranking.GetComponent<Rnaking>();

        Score = Rn.score;

        score.text = "" + Score[number - 1];

        Name = Rn.NAME;

        name.text = "" + Name[number - 1];


        this.transform.SetParent(UnityEngine.Object.FindObjectOfType<Canvas>().transform);

    }
	
	// Update is called once per frame
	void Update () {
        

    }

    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
