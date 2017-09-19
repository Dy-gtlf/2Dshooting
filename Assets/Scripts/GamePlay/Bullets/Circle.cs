using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {
	// circle
	public static IEnumerator circle(GameObject bullet, Vector3 pos) {
		int times = 2;
		int num = 40;
		int i, j;
		float delay = 0.6f;
		for ( i = 0; i < times; i++ ) {
			for ( j = 0; j < num; j++ ) {
				Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 360f * j / (float)num));
			}
			yield return new WaitForSeconds (delay);
			for ( j = 0; j < num; j++ ) {
				Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, (360f * j  + 180f) / (float)num));
			}
			yield return new WaitForSeconds (delay);
		}
		EnemyBulletMake.ready = true;
	}
}
