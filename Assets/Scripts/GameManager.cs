using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class GameManager : MonoBehaviour {

	public GameObject player;

	public GameObject playerBullet;

	public float Distance = 1.5f;

	public float shotDelay = 1f;
	private float ROF = 0f;

	public AudioClip playerBlast;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("CBSFly1", 2, 5);
		InvokeRepeating ("CBSFly2", 2, 5);
		InvokeRepeating ("CBSFly3", 2, 5);

		InvokeRepeating ("NBCFly1", 2.5f, 5);
		InvokeRepeating ("NBCFly2", 2.5f, 5);

		InvokeRepeating ("ABCFly1", 6, 5);
		InvokeRepeating ("ABCFly2", 6, 5);

		InvokeRepeating ("ViacomFly1", 10, 5);
		InvokeRepeating ("ViacomFly2", 10, 5);


	}
	
	// Update is called once per frame
	void Update () {
		bulletFire ();
	
	}

	void bulletFire(){

		if (Input.GetKey (KeyCode.Space) && (Time.time > ROF)) {

				ROF = Time.time + shotDelay;

				GameObject Bullet = Instantiate (Resources.Load ("Bullet")) as GameObject;

				Bullet.transform.position = player.transform.position;

				AudioSource playerBlast = GetComponent<AudioSource>();
				playerBlast.Play();
			}
		}


	void CBSFly1(){
		GameObject CBS = Instantiate (Resources.Load ("cbs")) as GameObject;

		CBS.transform.position = new Vector3 (38, 12, 0);
	}

	void CBSFly2(){
		GameObject CBS = Instantiate (Resources.Load ("cbs")) as GameObject;
		
		CBS.transform.position = new Vector3 (38, 0, 0);
	}

	void CBSFly3(){
		GameObject CBS = Instantiate (Resources.Load ("cbs")) as GameObject;
		
		CBS.transform.position = new Vector3 (38, -12, 0);
	}

	void NBCFly1(){
		GameObject NBC = Instantiate (Resources.Load ("nbc")) as GameObject;
		
		NBC.transform.position = new Vector3 (38, 7, 0);
	}
	
	void NBCFly2(){
		GameObject NBC = Instantiate (Resources.Load ("nbc")) as GameObject;
		
		NBC.transform.position = new Vector3 (38, -7, 0);
	}

	void ABCFly1(){
		GameObject ABC = Instantiate (Resources.Load ("abc")) as GameObject;
		
		ABC.transform.position = new Vector3 (38, 7, 0);
	}

	void ABCFly2(){
		GameObject ABC = Instantiate (Resources.Load ("abctoo")) as GameObject;
		
		ABC.transform.position = new Vector3 (38, -7, 0);
	}

	void ViacomFly1(){
		GameObject Viacom = Instantiate (Resources.Load ("viacom")) as GameObject;
		
		Viacom.transform.position = new Vector3 (48, 10, 0);
	}

	void ViacomFly2(){
		GameObject Viacom = Instantiate (Resources.Load ("viacom")) as GameObject;
		
		Viacom.transform.position = new Vector3 (48, -10, 0);
	}

}
	