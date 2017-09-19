using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MvCircle : MonoBehaviour {
	// moving circle
	public static IEnumerator mvCircle(GameObject bullet, Vector3 pos) {
		int num = 50;
		int k;
		float delay = 0.15f;
		for ( k = 0; k < num; k++ ) {
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 0f + 180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 90f + 180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 180f + 180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 270f + 180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 45f + 180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 135f + 180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 225f + 180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 315f + 180f * k / (float)num));
			k++;
			yield return new WaitForSeconds(delay);
		}
		for ( k = 0; k < num; k++ ) {
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 0f + -180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 90f + -180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 180f + -180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 270f + -180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 45f + -180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 135f + -180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 225f + -180f * k / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 315f + -180f * k / (float)num));
			k++;
			yield return new WaitForSeconds(delay);
		}
		yield return new WaitForSeconds(0.1f);
		EnemyBulletMake.ready = true;
	}
}
