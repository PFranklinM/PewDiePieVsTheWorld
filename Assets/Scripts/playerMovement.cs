using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour {

	public float moveAmount = 10f;

	public float yMax = 19f;
	public float yMin = -19f;

	public Sprite Pewdz1;
	public Sprite Pewdz2;
	
	private SpriteRenderer spriteRenderer;

	public int Health = 10;
	public GameObject healthText;


	// Use this for initialization
	void Start () {

		spriteRenderer = GetComponent<SpriteRenderer> ();
		if (spriteRenderer.sprite == null) {
			spriteRenderer.sprite = Pewdz1;
			
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 moving = new Vector3 (transform.position.x,
		                              transform.position.y,
		                              transform.position.z);

		if (Input.GetKey (KeyCode.W)) {
			moving.y += moveAmount * Time.deltaTime;
		}
		
		if (Input.GetKey (KeyCode.S)) {
			moving.y -= moveAmount * Time.deltaTime;
		}

		if (moving.y > yMax) {
			moving.y = yMin;
		}

		if (moving.y < yMin){
			moving.y = yMax;
		}

		transform.position = moving;

		if (Input.GetKey (KeyCode.Space)) {
			changeSprite ();
		} else {
			changeSpriteBack ();
		}


		Text text = healthText.GetComponent<Text>();
		text.text = "Health: " + Health;
		
				if (Health <= 0) {
					gameOver();
				}
	
	}


	void changeSprite (){
		
		spriteRenderer.sprite = Pewdz2;
		
	}
	
	void changeSpriteBack (){
		spriteRenderer.sprite = Pewdz1;
	}

	public void healthDownOne(){
		Health --;
	}
	
	public void healthDownTwo(){
		Health -= 2;
	}
	
	public void gameOver(){
		Application.LoadLevel("GameLose");
	}
}
