using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HomepanelButton : MonoBehaviour {
	public GameObject Homepanel;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BackHome(){
		SceneManager.LoadScene ("Menu");
	}
	public void Keepon(){
		Homepanel.SetActive (false);
	}
}
