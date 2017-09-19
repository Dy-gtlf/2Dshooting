using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public GameObject bullet;
	private float timer;
	public float move;
	public float dist;
	public float range_x;
	public float range_y;
	public static bool alive;
	void Start() {
		timer = dist;
		alive = true;
	}
	void Update() {
		// CheckInput();
		timer += Time.deltaTime;
		Vector3 touchScreenPosition = Input.mousePosition;
    	touchScreenPosition.x = Mathf.Clamp(touchScreenPosition.x, Screen.width / 2f - Screen.height / 2f, Screen.width / 2f + Screen.height / 2f);
    	touchScreenPosition.y =  Mathf.Clamp(touchScreenPosition.y, 0f, Screen.height);
    	touchScreenPosition.z = 10f;
    	Camera gameCamera = Camera.main;
    	Vector3 touchWorldPosition = gameCamera.ScreenToWorldPoint(touchScreenPosition);
    	this.transform.position = touchWorldPosition;
		if ( timer >= dist ) {
			Instantiate(bullet, new Vector3(transform.position.x,transform.position.y + 0.2f,transform.position.z), Quaternion.identity);
			Instantiate(bullet, new Vector3(transform.position.x,transform.position.y + 0.2f,transform.position.z), Quaternion.Euler(0f, 0f, 10f));
			Instantiate(bullet, new Vector3(transform.position.x,transform.position.y + 0.2f,transform.position.z), Quaternion.Euler(0f, 0f, -10f));
			timer -= dist;
		}
	}

	// void CheckInput() {
		// if (Input.GetKey(KeyCode.LeftArrow)) {
		// 	if (transform.position.x > -1 * range_x) {
		// 		gameObject.transform.position += new Vector3(-1f * move, 0f, 0f);
		// 	}
		// }
		// if (Input.GetKey(KeyCode.RightArrow)) {
		// 	if (transform.position.x < range_x) {
		// 		gameObject.transform.position += new Vector3(move, 0f, 0f);
		// 	}
		// }
		// if (Input.GetKey(KeyCode.UpArrow)) {
		// 	if (transform.position.y < range_y) {
		// 		gameObject.transform.position += new Vector3(0f, move, 0f);
		// 	}
		// }
		// if (Input.GetKey(KeyCode.DownArrow)) {
		// 	if (transform.position.y > -1 * range_y) {
		// 		gameObject.transform.position += new Vector3(0f, -1f * move, 0f);
		// 	}
		// }
	// }

	void OnCollisionEnter (Collision collision) {
   		if (collision.gameObject.tag == "Enemy") {
			alive = false;
			Destroy(this.gameObject);
		}
	}

}
