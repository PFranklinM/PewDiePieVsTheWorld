using UnityEngine;
using System.Collections;

public class bulletMove : MonoBehaviour {

	public float moveSpeed = 10;
	public float xMax = 38.0f;

	public GameObject Bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 newPos = new Vector3 (transform.position.x,
		                              transform.position.y,
		                              transform.position.z);
		
		newPos.x += moveSpeed * Time.deltaTime;
		
		transform.position = newPos;
		
		if (newPos.x >= xMax) {
			Destroy(Bullet);
		}
	
	}

	public void destroyBullet(){
		Destroy (Bullet);
	}
}
