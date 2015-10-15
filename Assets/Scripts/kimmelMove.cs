using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class kimmelMove : MonoBehaviour {

	public float moveSpeed = 10;
	public float stopPos = 22;

	private float yMax = 12;
	private float yMin = -12;
	
	public GameObject JK;
	
	public float enemyShotDelay = 1f;
	public GameObject enemyBullet;
	private float ROF = 0f;

	public AudioClip BossLaugh;
	public bool didLaugh = false;


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

		if (newPos.x > stopPos) {
			horizontalMove();
		}

		if (newPos.x <= stopPos) {
			vertMove();
		}
	
	}

	void horizontalMove(){

		Vector3 newPos = new Vector3 (transform.position.x,
		                              transform.position.y,
		                              transform.position.z);
		
		newPos.x -= moveSpeed * Time.deltaTime;
		
		transform.position = newPos;

		bossLaugh();
	}

	void vertMove(){

		Vector3 newPos = new Vector3 (transform.position.x,
		                              transform.position.y,
		                              transform.position.z);

		newPos.y += moveSpeed * Time.deltaTime;

		transform.position = newPos;

		if (newPos.y + moveSpeed * Time.deltaTime >= yMax || newPos.y + moveSpeed * Time.deltaTime <= yMin) {
			moveSpeed = -moveSpeed;
		}
	}

	void enemyBulletShoot(){
		
		GameObject enemyBullet = Instantiate (Resources.Load ("enemyBullet2")) as GameObject;
		enemyBullet.transform.position = JK.transform.position;
	}

	void bossLaugh(){
		if (didLaugh == false) {
			AudioSource BossLaugh = GetComponent<AudioSource> ();
			BossLaugh.Play ();
			didLaugh = true;
		}
	}
}
