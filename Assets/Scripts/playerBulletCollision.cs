using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerBulletCollision : MonoBehaviour {

	public GameObject bullet;
	public GameObject ScoreText;

//	public bool gotScore;

	public int Score = 0;

	// Use this for initialization
	void Start () {

//		gotScore = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		ScoreText = GameObject.Find ("Score");

//		Text text = ScoreText.GetComponent<Text> ();
//		text.text = "Score: " + Score;

//		if (gotScore == true) {
//			Score += 100;
//			gotScore = false;
//			
//		}

	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.CompareTag("target")){
			Destroy(coll.gameObject);
//			gotScore = true;
			Destroy(bullet);
		}

		if (coll.gameObject.tag == "jk") {
			Destroy (bullet);
		}
	}

}
