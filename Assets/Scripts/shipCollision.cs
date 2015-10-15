using UnityEngine;
using System.Collections;

public class shipCollision : MonoBehaviour {

	public GameObject ship;
	public GameObject player;

	public float Distance = 1.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		player = GameObject.Find ("pewds1");
		
		if (Vector3.Distance (ship.transform.position, player.transform.position) < Distance) {
			player.GetComponent<playerMovement>().gameOver();
			Destroy(ship);
		}
	
	}
}
