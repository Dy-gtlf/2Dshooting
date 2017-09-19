using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public int health;
	public static bool alive;
	void Update () {
		alive = true;
		move();
	}
	// hit
	void OnCollisionEnter (Collision collision) {
   		if (collision.gameObject.tag == "P_Bullet") {
			health--;
			Destroy(collision.gameObject);
			if ( health <= 0 ) {
				alive = false;
				Destroy(this.gameObject);
			}
		}
	}

	void move() {
		
	}
}
