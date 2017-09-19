using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed;
	void Update () {
		this.transform.Translate(0f, speed * 2f, 0f);
	}

	void OnBecameInvisible(){	
        Destroy (this.gameObject);
    }

}
