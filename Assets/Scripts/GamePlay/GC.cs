using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GC : MonoBehaviour {
	Renderer text = new Renderer();
	void Awake() {
		text = this.gameObject.GetComponent<Renderer>();
		text.enabled = false;
	}
	void Update() {
		if (Enemy.alive == false && text.enabled == false) {
			text.enabled = true;
			Time.timeScale = 0;
		}
		if (Enemy.alive == false && Input.GetKeyDown(KeyCode.Space)) {
			StartCoroutine("delay");
			SceneManager.LoadScene("Title");
		}
	}
	IEnumerator delay() {
		yield return new WaitForSeconds(0.5f);
	}
}
