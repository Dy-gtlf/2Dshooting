using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour {
	void Start() {
		Time.timeScale = 1;
	}
	void Update() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			StartCoroutine("delay");
			SceneManager.LoadScene("GamePlay");
		}
	}
	IEnumerator delay() {
		yield return new WaitForSeconds(0.5f);
	}
}
