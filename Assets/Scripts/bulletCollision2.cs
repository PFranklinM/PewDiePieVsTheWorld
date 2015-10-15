using UnityEngine;
using System.Collections;

public class bulletCollision2 : MonoBehaviour {

	public GameObject bullet;
	public GameObject player;
	
	public float Distance = 1.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		player = GameObject.Find ("pewds1");
		
		if (Vector3.Distance (bullet.transform.position, player.transform.position) < Distance) {
			player.GetComponent<playerMovement>().healthDownTwo();
			Destroy(bullet);
		}
	
	}
}
