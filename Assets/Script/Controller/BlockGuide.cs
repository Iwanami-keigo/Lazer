using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGuide : MonoBehaviour {
	private GameObject block;
	private GameObject startarea;
	private GameObject blocktouch;
	// Use this for initialization
	void Start () {
		block = GameObject.Find ("Block");
		startarea = GameObject.Find ("StartArea");
		blocktouch = GameObject.Find ("Blocktouch");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = startarea.transform.position;
		transform.rotation = block.transform.rotation;
		
	}
}
