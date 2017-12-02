using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotation : MonoBehaviour {

	public int rotationOffset;
	public float lifeTime;

	public GameObject shot;
	public Transform pos;

	void Update(){

		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		difference.Normalize();

		float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler (0f, 0f, rotZ + 90);


		if(Input.GetMouseButtonDown(0)){
			
			GameObject shoty = (GameObject)Instantiate(shot, pos.transform.position, pos.transform.rotation);
			Destroy(shoty, lifeTime);
		}
	}
}
