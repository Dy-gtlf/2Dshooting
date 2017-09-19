using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MvCircleR : MonoBehaviour {
	// moving circle
	public static IEnumerator mvCircleR(GameObject bullet, Vector3 pos) {
		int num = 55;
		int k;
		float delay = 0.02f;
		for ( k = 0; k < 2 * num; k++ ) {
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, -360 * k / (float)num));
			k++;
			yield return new WaitForSeconds(delay);
		}
		yield return new WaitForSeconds(0.1f);
		EnemyBulletMake.ready = true;
	}
}
