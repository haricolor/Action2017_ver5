using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour {
	
	void Update () {
        this.gameObject.GetComponent<Slider>().value = Player.HP;
    }
}
