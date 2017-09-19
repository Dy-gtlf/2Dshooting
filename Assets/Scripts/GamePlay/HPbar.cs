using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour {
	Slider slider;
	GameObject enemy;
	void Start () {
		slider = this.GetComponent<Slider>();
		enemy = GameObject.Find("Enemy");
	}
	void Update () {
		if ( Enemy.alive ) {
			slider.value = enemy.GetComponent<Enemy>().health;;
		}
	}
}
