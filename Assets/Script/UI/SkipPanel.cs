using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkipPanel : MonoBehaviour {
	public GameObject skippanel;
	public  GameObject panel;

	public AudioClip skipse;
	private AudioSource audiosource;
	PanelController panelcontroller;
	public string stagename;
	private int clearcomplate;
	// Use this for initialization
	void Start () {
		panelcontroller = panel.GetComponent<PanelController> ();
		stagename = SceneManager.GetActiveScene ().name;
		clearcomplate = PlayerPrefs.GetInt ("STAGE", 1);
		audiosource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BackHome(){
		panel.SetActive (true);
		audiosource.PlayOneShot (skipse);
		panelcontroller.skipflag = true;
		Invoke ("stageskip", 2.5f);
}
	public void Keepon(){
		skippanel.SetActive (false);
	}
	void stageskip(){
		PlayerManeger.deadcount = 0;
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
		if (SceneManager.GetActiveScene ().name == "Gamescene") {
			SceneManager.LoadScene ("Stage1");
		} else if (SceneManager.GetActiveScene ().name == "Stage1") {
			SceneManager.LoadScene ("Stage2");
		} else if (SceneManager.GetActiveScene ().name == "Stage2") {
			SceneManager.LoadScene ("Stage3");
		} else if (SceneManager.GetActiveScene ().name == "Stage3") {
			SceneManager.LoadScene ("Stage4");
		} else if (SceneManager.GetActiveScene ().name == "Stage4") {
			SceneManager.LoadScene ("Stage5");
		} else if (SceneManager.GetActiveScene ().name == "Stage5") {
			SceneManager.LoadScene ("Stage6");
		} else if (SceneManager.GetActiveScene ().name == "Stage6") {
			SceneManager.LoadScene ("Stage7");
		} else if (SceneManager.GetActiveScene ().name == "Stage7") {
			SceneManager.LoadScene ("Stage8");
		} else if (SceneManager.GetActiveScene ().name == "Stage8") {
			SceneManager.LoadScene ("Stage9");
		} else if (SceneManager.GetActiveScene ().name == "Stage9") {
			SceneManager.LoadScene ("Stage10");
		} else if (SceneManager.GetActiveScene ().name == "Stage10") {
			SceneManager.LoadScene ("Stage11");
		} else if (SceneManager.GetActiveScene ().name == "Stage11") {
			SceneManager.LoadScene ("Stage12");
		} else if (SceneManager.GetActiveScene ().name == "Stage12") {
			SceneManager.LoadScene ("Stage13");
		} else if (SceneManager.GetActiveScene ().name == "Stage13") {
			SceneManager.LoadScene ("Stage14");
		} else if (SceneManager.GetActiveScene ().name == "Stage14") {
			SceneManager.LoadScene ("Stage15");
		} else if (SceneManager.GetActiveScene ().name == "Stage15") {
			SceneManager.LoadScene ("Stage16");
		} else if (SceneManager.GetActiveScene ().name == "Stage16") {
			SceneManager.LoadScene ("Stage17");
		} else if (SceneManager.GetActiveScene ().name == "Stage17") {
			SceneManager.LoadScene ("Stage18");
		} else if (SceneManager.GetActiveScene ().name == "Stage18") {
			SceneManager.LoadScene ("Stage19");
		} else if (SceneManager.GetActiveScene ().name == "Stage19") {
			SceneManager.LoadScene ("Stage20");
		} else if (SceneManager.GetActiveScene ().name == "Stage20") {
			SceneManager.LoadScene ("Stage21");
		} else if (SceneManager.GetActiveScene ().name == "Stage21") {
			SceneManager.LoadScene ("Stage22");
		} else if (SceneManager.GetActiveScene ().name == "Stage22") {
			SceneManager.LoadScene ("Stage23");
		} else if (SceneManager.GetActiveScene ().name == "Stage23") {
			SceneManager.LoadScene ("Stage24");
		} else if (SceneManager.GetActiveScene ().name == "Stage24") {
			SceneManager.LoadScene ("Stage25");
		} else if (SceneManager.GetActiveScene ().name == "Stage25") {
			SceneManager.LoadScene ("Stage26");
		} else if (SceneManager.GetActiveScene ().name == "Stage26") {
			SceneManager.LoadScene ("Stage27");
		} else if (SceneManager.GetActiveScene ().name == "Stage27") {
			SceneManager.LoadScene ("Stage28");
		} else if (SceneManager.GetActiveScene ().name == "Stage28") {
			SceneManager.LoadScene ("Stage29");
		} else if (SceneManager.GetActiveScene ().name == "Stage29") {
			SceneManager.LoadScene ("Stage30");
		}
	}
}
