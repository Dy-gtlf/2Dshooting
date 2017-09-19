using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissor : MonoBehaviour {
	public static IEnumerator scissor(GameObject bullet, Vector3 pos) {
		int num = 60;
		int k;
		float delay = 0.1f;
		for ( k = 0; k < num; k++ ) {
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 45f +(270f * k - 180f)/ (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, -45f + (-270f * k + 180f) / (float)num));

			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 90f + (270f * k) / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, -90f + (-270f * k) / (float)num));

			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, 180f + (270f * k) / (float)num));
			Instantiate(bullet, pos, Quaternion.Euler(0f, 0f, -180f + (-270f * k) / (float)num));
			
			k++;
			yield return new WaitForSeconds(delay);
		}
		yield return new WaitForSeconds(0.1f);
		EnemyBulletMake.ready = true;
	}
}
