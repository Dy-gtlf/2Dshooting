using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snipe : MonoBehaviour {
	public static IEnumerator mvCircle(GameObject bullet, Vector3 pos) {
		int num = 50;
		int k;
		float delay = 0.1f;
		float x;
		float y;
		float rad;
		for ( k = 0; k < num; k++ ) {
			if ( Player.alive == false ) {
				break;
			}
			x = GameObject.Find("Player").transform.position.x - GameObject.Find("Enemy").transform.position.x;
			y = GameObject.Find("Player").transform.position.y - GameObject.Find("Enemy").transform.position.y;
			rad = Mathf.Atan2(y, x);
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, -90f + rad * 180f / Mathf.PI));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, -110f + rad * 180f / Mathf.PI));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, -70f + rad * 180f / Mathf.PI));
			k++;
			yield return new WaitForSeconds(delay);
		}
		yield return new WaitForSeconds(0.1f);
		EnemyBulletMake.ready = true;
	}
}
