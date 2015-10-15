using UnityEngine;
using System.Collections;

public class abcMove : MonoBehaviour {

	public float moveSpeed = 10;
	public float xMin = -38.0f;

	public float amplitude = 1;
	public float frequency = 1;
	
	public GameObject ABC;
	
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

		Vector3 moving = new Vector3 (transform.position.x,
		                              transform.position.y,
		                              transform.position.z);

		moving.x -= moveSpeed * Time.deltaTime;
		
		moving.y = Mathf.Sin (moving.x * frequency) * amplitude;

		transform.position = moving;

		if (moving.x <= xMin) {
			Destroy(ABC);
		}
	
	}


	void enemyBulletShoot(){

		GameObject enemyBullet = Instantiate (Resources.Load ("enemyBullet")) as GameObject;
		enemyBullet.transform.position = ABC.transform.position;
	}
}
