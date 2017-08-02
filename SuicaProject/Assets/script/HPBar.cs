using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour {

    public GameObject This;

    private void Start()
    {
        This.transform.SetParent(UnityEngine.Object.FindObjectOfType<Canvas>().transform);
    }

    void Update () {
        This.gameObject.GetComponent<Slider>().value = Player.HP;
    }
}
