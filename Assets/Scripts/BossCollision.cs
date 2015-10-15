using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BossCollision : MonoBehaviour {

	public int BossHealth = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (BossHealth <= 0) {
			Application.LoadLevel ("GameWin");
		}
	
	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "target") {
			BossHealth -= 1;
			Debug.Log (BossHealth);
		
		}
	}
}
