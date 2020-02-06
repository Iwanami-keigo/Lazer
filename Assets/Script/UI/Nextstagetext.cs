using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nextstagetext : MonoBehaviour {

	Text mytext;
	public string stagename;
	// Use this for initialization
	void Start () {
		this.mytext = GetComponent<Text> ();
		stagename = SceneManager.GetActiveScene ().name;
		if (SceneManager.GetActiveScene ().name == "Stage1") {
			mytext.text = "Stage2→";
		} else if (SceneManager.GetActiveScene ().name == "Stage2") {
			mytext.text = "Stage3→";
		} else if (SceneManager.GetActiveScene ().name == "Stage3") {
			mytext.text = "Stage4→";
		} else if (SceneManager.GetActiveScene ().name == "Stage4") {
			mytext.text = "Stage5→";
		} else if (SceneManager.GetActiveScene ().name == "Stage5") {
			mytext.text = "Stage6→";
		} else if (SceneManager.GetActiveScene ().name == "Stage6") {
			mytext.text = "Stage7→";
		} else if (SceneManager.GetActiveScene ().name == "Stage7") {
			mytext.text = "Stage8→";
		} else if (SceneManager.GetActiveScene ().name == "Stage8") {
			mytext.text = "Stage9→";
		} else if (SceneManager.GetActiveScene ().name == "Stage9") {
			mytext.text = "Stage10→";
		} else if (SceneManager.GetActiveScene ().name == "Stage10") {
			mytext.text = "Stage11→";
		} else if (SceneManager.GetActiveScene ().name == "Stage11") {
			mytext.text = "Stage12→";
		} else if (SceneManager.GetActiveScene ().name == "Stage12") {
			mytext.text = "Stage13→";
		} else if (SceneManager.GetActiveScene ().name == "Stage13") {
			mytext.text = "Stage14→";
		} else if (SceneManager.GetActiveScene ().name == "Stage14") {
			mytext.text = "Stage15→";
		} else if (SceneManager.GetActiveScene ().name == "Stage15") {
			mytext.text = "Stage16→";
		} else if (SceneManager.GetActiveScene ().name == "Stage16") {
			mytext.text = "Stage17→";
		} else if (SceneManager.GetActiveScene ().name == "Stage17") {
			mytext.text = "Stage18→";
		} else if (SceneManager.GetActiveScene ().name == "Stage18") {
			mytext.text = "Stage19→";
		} else if (SceneManager.GetActiveScene ().name == "Stage19") {
			mytext.text = "Stage20→";
		} else if (SceneManager.GetActiveScene ().name == "Stage20") {
			mytext.text = "Stage21→";
		} else if (SceneManager.GetActiveScene ().name == "Stage21") {
			mytext.text = "Stage22→";
		} else if (SceneManager.GetActiveScene ().name == "Stage22") {
			mytext.text = "Stage23→";
		} else if (SceneManager.GetActiveScene ().name == "Stage23") {
			mytext.text = "Stage24→";
		} else if (SceneManager.GetActiveScene ().name == "Stage24") {
			mytext.text = "Stage25→";
		} else if (SceneManager.GetActiveScene ().name == "Stage25") {
			mytext.text = "Stage26→";
		} else if (SceneManager.GetActiveScene ().name == "Stage26") {
			mytext.text = "Stage27→";
		} else if (SceneManager.GetActiveScene ().name == "Stage27") {
			mytext.text = "Stage28→";
		} else if (SceneManager.GetActiveScene ().name == "Stage28") {
			mytext.text = "Stage29→";
		} else if (SceneManager.GetActiveScene ().name == "Stage29") {
			mytext.text = "Stage30→";
		}

	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
}
