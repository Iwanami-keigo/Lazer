using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GoalController : MonoBehaviour {

	private bool isEnd = false;
	private GameObject GoalText;
	private ParticleSystem Pt;
	private GameObject panel;

	AudioSource audiosource;
	public AudioClip goalse;

	public string stagename;
	private int clearcomplate;

	// Use this for initialization
	void Start () {
		this.GoalText = GameObject.Find ("GoalResult");
		audiosource = GetComponent<AudioSource> ();
		panel = GameObject.Find ("Panel");
		stagename = SceneManager.GetActiveScene ().name;
		clearcomplate = PlayerPrefs.GetInt ("STAGE", 1);

	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "PlayerTag" || other.gameObject.tag == "InvincibleTag") {
			panel.SetActive (true);
			this.gameObject.tag = "GoalEnterTag";
			isEnd = true;
			this.GoalText.GetComponent<Text> ().text = "CLEAR!!";
			GetComponent<ParticleSystem> ().Play ();
			audiosource.PlayOneShot (goalse);

			if (stagename == "Stage1" && clearcomplate <= 1) {
				
				PlayerPrefs.SetInt ("STAGE", 2);
			}

			if (stagename == "Stage2"&& clearcomplate <= 2) {
				PlayerPrefs.SetInt ("STAGE", 3);
			}

			if (stagename == "Stage3"&& clearcomplate <= 3) {
				PlayerPrefs.SetInt ("STAGE", 4);
			}

			if (stagename == "Stage4"&& clearcomplate <= 4) {
				PlayerPrefs.SetInt ("STAGE", 5);
			}

			if (stagename == "Stage5"&& clearcomplate <= 5) {
				PlayerPrefs.SetInt ("STAGE", 6);
			}

			if (stagename == "Stage6" && clearcomplate <= 6) {
				PlayerPrefs.SetInt ("STAGE", 7);
			}

			if (stagename == "Stage7" && clearcomplate <= 7) {
				PlayerPrefs.SetInt ("STAGE", 8);
			}

			if (stagename == "Stage8" && clearcomplate <=8) {
				PlayerPrefs.SetInt ("STAGE", 9);
			}

			if (stagename == "Stage9" && clearcomplate <= 9) {
				PlayerPrefs.SetInt ("STAGE", 10);
			}

			if (stagename == "Stage10" && clearcomplate <= 10) {
				PlayerPrefs.SetInt ("STAGE", 11);
			}

			if (stagename == "Stage11" && clearcomplate <= 11) {
				PlayerPrefs.SetInt ("STAGE", 12);
			}

			if (stagename == "Stage12" && clearcomplate <= 12) {
				PlayerPrefs.SetInt ("STAGE", 13);
			}

			if (stagename == "Stage13" && clearcomplate <= 13) {
				PlayerPrefs.SetInt ("STAGE", 14);
			}

			if (stagename == "Stage14" && clearcomplate <= 14) {
				PlayerPrefs.SetInt ("STAGE", 15);
			}

			if (stagename == "Stage15" && clearcomplate <= 15) {
				PlayerPrefs.SetInt ("STAGE", 16);
			}

			if (stagename == "Stage16" && clearcomplate <= 16) {
				PlayerPrefs.SetInt ("STAGE", 17);
			}

			if (stagename == "Stage17" && clearcomplate <= 17) {
				PlayerPrefs.SetInt ("STAGE", 18);
			}

			if (stagename == "Stage18" && clearcomplate <= 18) {
				PlayerPrefs.SetInt ("STAGE", 19);
			}

			if (stagename == "Stage19" && clearcomplate <= 19) {
				PlayerPrefs.SetInt ("STAGE", 20);
			}

			if (stagename == "Stage20" && clearcomplate <= 20) {
				PlayerPrefs.SetInt ("STAGE", 21);
			}

			if (stagename == "Stage21" && clearcomplate <= 21) {
				PlayerPrefs.SetInt ("STAGE", 22);
			}

			if (stagename == "Stage22" && clearcomplate <= 22) {
				PlayerPrefs.SetInt ("STAGE", 23);
			}

			if (stagename == "Stage23" && clearcomplate <= 23) {
				PlayerPrefs.SetInt ("STAGE", 24);
			}

			if (stagename == "Stage24" && clearcomplate <= 24) {
				PlayerPrefs.SetInt ("STAGE", 25);
			}

			if (stagename == "Stage25" && clearcomplate <= 25) {
				PlayerPrefs.SetInt ("STAGE", 26);
			}

			if (stagename == "Stage26" && clearcomplate <= 26) {
				PlayerPrefs.SetInt ("STAGE", 27);
			}

			if (stagename == "Stage27" && clearcomplate <= 27) {
				PlayerPrefs.SetInt ("STAGE", 28);
			}

			if (stagename == "Stage28" && clearcomplate <= 28) {
				PlayerPrefs.SetInt ("STAGE", 29);
			}

			if (stagename == "Stage29" && clearcomplate <= 29) {
				PlayerPrefs.SetInt ("STAGE", 30);
			}

			if (stagename == "Stage30" && clearcomplate <= 30) {
				PlayerPrefs.SetInt ("STAGE", 31);
			}

			PlayerPrefs.SetString (stagename, "CLEAR");
			Debug.Log ("CLEAR");
			PlayerPrefs.Save ();




		}
	}


}
