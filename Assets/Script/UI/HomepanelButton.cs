using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HomepanelButton : MonoBehaviour {
	public GameObject Homepanel;
	public GameObject panel;
	public AudioClip menuback;
	private AudioSource audiosource;
	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BackHome(){
		tag = "Buttonnull";
		panel.SetActive (true);
		audiosource.PlayOneShot (menuback);
		Invoke ("MenuLoad", 2.5f);
	}
	public void Keepon(){
		Homepanel.SetActive (false);
	}
	private void MenuLoad(){
		SceneManager.LoadScene ("Menu");
	}
}
