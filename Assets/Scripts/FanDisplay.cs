using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FanDisplay : MonoBehaviour {

	public GameObject fanNumberText;
	public GameObject JK;
	public GameObject FN;

	float fans = 1;

	private float fanCounter = 0f;
	public float fanDelay = 60f;
	private bool once = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > fanCounter) {
			fanCounter = Time.time + fanDelay;
			fans *= 2;
		}

//		Debug.Log (i);

		Text text = fanNumberText.GetComponent<Text>();
		text.text = "" + fans;

		if (fans >= 1000) {
			text.text = (fans/1000) + " Thousand";
		} 

		if (fans >= 1000000) {
			text.text = (fans/1000000) + " Million";
		}

		if (fans >= 1000000000) {
			text.text = (fans/1000000000) + " Billion";
		}

		if (fans >= 7300000000) {
			fans = 7300000000;
			text.text = "7.3 Billion";
		}

		if (fans >= 7300000000 && once == true) {
			jimmySpawn();
			once = false;
		}
	}

	void jimmySpawn(){

		GameObject JK1 = Instantiate (Resources.Load ("JK1")) as GameObject;
		JK1.transform.position = new Vector3 (48, 0, 0);
//		JK1.GetComponent<enemyLifeBoss>().showBossHealth();
	}

}
