using UnityEngine;
using System.Collections;

public class enemyBulletSeek : MonoBehaviour {

	public float bulletMoveSpeed = 10;
	public float xMin = -38.0f;

	public GameObject enemyBullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 newPos = new Vector3 (transform.position.x,
		                              transform.position.y,
		                              transform.position.z);
		
		newPos.x -= bulletMoveSpeed * Time.deltaTime;
		
		transform.position = newPos;
		
		if (newPos.x <= xMin) {
			Destroy(enemyBullet);
		}
	
	}
}
