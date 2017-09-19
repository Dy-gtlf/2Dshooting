using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMake : MonoBehaviour {

	public int patternCount;
	public List<GameObject> bullet;
	private int mode = -1;
	private int p_mode = -1;
	public static bool ready;
	void Start() {
		ready = true;
	}
	void Update() {
		if ( ready ) {
			ready = false;
			while ( mode == p_mode ) {
				mode = Random.Range(0, patternCount);
			}
			p_mode = mode;
			// mode = 4;
			Debug.Log(mode);
			switch (mode) {
				case 0 :
					StartCoroutine(Circle.circle(bullet[mode], this.transform.position));
					break;
				case 1 :
					StartCoroutine(MvCircle.mvCircle(bullet[mode], this.transform.position));
					break;
				case 2 :
					StartCoroutine(Snipe.mvCircle(bullet[mode], this.transform.position));
					break;
				case 3 :
					StartCoroutine(MvCircleR.mvCircleR(bullet[mode], this.transform.position));
					break;
				case 4 :
					StartCoroutine(Scissor.scissor(bullet[mode], this.transform.position));
					break;
			}
		}
	}
}