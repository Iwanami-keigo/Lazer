using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSpin : MonoBehaviour {
	public float z;
	private float backup;

	// Use this for initialization
	void Start () {
		backup = z;
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0, 0, z);
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "MagnetTag") {
			z = 0;
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "MagnetTag") {
			z = backup;
		}
	}
}
