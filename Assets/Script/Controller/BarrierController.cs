using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierController : MonoBehaviour {
	private GameObject Player;
    
	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.tag == "PlayerTag") {
			gameObject.GetComponent<BoxCollider2D> ().isTrigger = false;
		} else {
			gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;
		}
	}
}
