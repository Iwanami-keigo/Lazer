using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiclreBattery : MonoBehaviour {
	private GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (player.tag == "PlayerTag") {
			gameObject.GetComponent<CircleCollider2D> ().isTrigger = false;
		} else {
			gameObject.GetComponent<CircleCollider2D> ().isTrigger = true;
		}
	}
}
