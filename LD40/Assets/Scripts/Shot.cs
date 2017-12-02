using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

	public float speed;
	private Rigidbody2D rb;

	void Start(){
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate(){

		rb.MovePosition(transform.position + transform.up * -speed * Time.fixedDeltaTime);
	}
}
