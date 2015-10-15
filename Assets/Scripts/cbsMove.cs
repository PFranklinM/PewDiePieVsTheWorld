using UnityEngine;
using System.Collections;

public class cbsMove : MonoBehaviour {

	public float moveSpeed = 10;
	public float xMin = -38.0f;

	public GameObject CBS;
	
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
		
		if (newPos.x <= xMin) {
			Destroy(CBS);
		}
		
	}

	void enemyBulletShoot(){

		GameObject enemyBullet = Instantiate (Resources.Load ("enemyBullet")) as GameObject;
		enemyBullet.transform.position = CBS.transform.position;
	}
}