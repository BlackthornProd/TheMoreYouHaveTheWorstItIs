using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedPatrol : MonoBehaviour {

	public float speed;
	public float startChangePos;
	private float changePos;

	private Transform target;
	private GameMaster gm;


	void Start(){

		gm = GameObject.FindGameObjectWithTag("Game Master").GetComponent<GameMaster>();
		changePos = 0;
	}


	void Update(){

		if(changePos <= 0){
			int randomPos = Random.Range(0, gm.poses.Length);
			target = gm.poses[randomPos];
			changePos = startChangePos;
		} else {
			changePos -= Time.deltaTime;
		}


		transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
	}
}
