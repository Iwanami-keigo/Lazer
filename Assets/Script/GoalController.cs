using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour {

	private bool isEnd = false;
	private GameObject GoalText;
	private ParticleSystem Pt;



	// Use this for initialization
	void Start () {
		this.GoalText = GameObject.Find ("GoalResult");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "PlayerTag") {
			this.gameObject.tag = "GoalEnterTag";
			isEnd = true;
			this.GoalText.GetComponent<Text> ().text = "CLEAR!!";
		  GetComponent<ParticleSystem> ().Play ();
		}
	}
}
