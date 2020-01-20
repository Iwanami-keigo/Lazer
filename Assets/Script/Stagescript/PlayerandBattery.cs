using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerandBattery : MonoBehaviour {

	bool magnetbool = false;
	GameObject player;
	Vector3 nowposition;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		Vector3 playerpos = player.transform.position;

		pos.x = playerpos.x;

		nowposition = transform.position;

		if (magnetbool == false) {
			transform.position = pos;
		}else{
			transform.position = nowposition;
	}
	

}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "MagnetTag") {
			magnetbool = true;
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "MagnetTag") {
			magnetbool = false;
		}
	}

}