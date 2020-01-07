using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour {

	private bool isEnd = false;
	private GameObject GoalText;
	private ParticleSystem Pt;
	public GameObject panel;

	AudioSource audiosource;
	public AudioClip goalse;

	// Use this for initialization
	void Start () {
		this.GoalText = GameObject.Find ("GoalResult");
		audiosource = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.tag == "GoalEnterTag") {
			Ptattack ();
		}
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "PlayerTag" || other.gameObject.tag == "InvincibleTag") {
			panel.SetActive (true);
			this.gameObject.tag = "GoalEnterTag";
			isEnd = true;
			this.GoalText.GetComponent<Text> ().text = "CLEAR!!";
			GetComponent<ParticleSystem> ().Play ();
			audiosource.PlayOneShot (goalse);


		}
	}
	void Ptattack(){
		
	}

}
