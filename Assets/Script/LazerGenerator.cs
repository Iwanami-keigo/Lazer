using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerGenerator : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			}
	void OnBecameInvisible(){
		Destroy (this.gameObject);
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "PlayerTag") {
			GameObject.Find ("PlayerManeger").GetComponent<PlayerManeger> ().InvokeRetornPlayer ();

		}
		if (other.gameObject.tag != "BatteryTag" && other.gameObject.tag == "BlockTag" || other.gameObject.tag == "PlayerTag") {
			Destroy (this.gameObject);
		}  


			}

		}
