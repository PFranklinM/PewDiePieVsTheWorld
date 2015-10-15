using UnityEngine;
using System.Collections;

public class viacomMove : MonoBehaviour {

	public float moveSpeed = 10;
	public float stopPos = 24;

	public GameObject Viacom;

	public float enemyShotDelay = 1f;
	public GameObject enemyBullet;
	private float ROF = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > ROF) {
			ROF = Time.time + enemyShotDelay;
			enemyBulletShoot();
		}

		Vector3 newPos = new Vector3 (transform.position.x,
		                              transform.position.y,
		                              transform.position.z);
		
		newPos.x -= moveSpeed * Time.deltaTime;
		
		transform.position = newPos;
		
		if (newPos.x <= stopPos) {
			moveSpeed = 0;
		}
	
	}

	void enemyBulletShoot(){
		
		GameObject enemyBullet = Instantiate (Resources.Load ("enemyBullet2")) as GameObject;
		enemyBullet.transform.position = Viacom.transform.position;
	}
}
