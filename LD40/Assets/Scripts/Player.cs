using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[Header ("References")]
	private Rigidbody2D rb;
	public GameObject egg;

	[Header ("Stats")]
	public float speed;
	public float startTimeBtwEgg;
	private float timeBtwEgg;
	public int health = 5;
	public int babiesKilled = 0;

	void Start(){
		timeBtwEgg = 0;
		rb = GetComponent<Rigidbody2D>();
	}


	void FixedUpdate(){


		// Moves the character !!
		if(Input.GetKey(KeyCode.LeftArrow)){
			rb.MovePosition(transform.position + transform.right * -speed * Time.fixedDeltaTime);
		} else if(Input.GetKey(KeyCode.RightArrow)){
			rb.MovePosition(transform.position + transform.right * speed * Time.fixedDeltaTime);
		} else if(Input.GetKey(KeyCode.UpArrow)){
			rb.MovePosition(transform.position + transform.up * speed * Time.fixedDeltaTime);
		} else if(Input.GetKey(KeyCode.DownArrow)){
			rb.MovePosition(transform.position + transform.up * -speed * Time.fixedDeltaTime);
		}



		// Spawns egg
		if(Input.GetMouseButtonDown(1) && timeBtwEgg <= 0){
			Instantiate(egg, transform.position, Quaternion.identity);
			timeBtwEgg = startTimeBtwEgg;
		} else {
			timeBtwEgg -= Time.deltaTime;
		}
	}

}
