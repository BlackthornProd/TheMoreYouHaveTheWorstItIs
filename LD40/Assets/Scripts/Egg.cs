using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour {

	public float timeBeforeHatch;

	public GameObject[] randomBaby;

	void Update(){
		if(timeBeforeHatch <= 0){
			int random = Random.Range(0, randomBaby.Length);
			Instantiate(randomBaby[random], transform.position, Quaternion.identity);
			Destroy(gameObject);
		} else {
			timeBeforeHatch -= Time.deltaTime;
		}
	}
}
