using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menubackground : MonoBehaviour {

	GameObject playbutton;

	// Use this for initialization
	void Start () {
		playbutton = GameObject.Find ("PlayButton");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void PlayButtonrestart(){
		if(!playbutton.activeSelf){
			playbutton.SetActive (true);
		}
}
}
