using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour {
	private Text txt;
	float fps;
	void Start () {
		txt = GetComponent<Text>();
	}
	void Update() {
    	fps = 1f / Time.deltaTime;
		txt.text = "FPS:" + fps; 
    }
}
