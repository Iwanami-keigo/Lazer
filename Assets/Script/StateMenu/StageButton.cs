using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageButton : MonoBehaviour {

	private string stagename;
	private GameObject panel;
	TitlePanel titlepanel;
	// Use this for initialization
	void Start () {
		stagename = this.gameObject.name;
		panel = GameObject.Find ("StartPanel");
		titlepanel = panel.GetComponent<TitlePanel> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void stagepush(){
		panel.SetActive (true);
		titlepanel.panelon = true;
		Invoke ("stagechange", 3);
}
	public void stagechange(){
		SceneManager.LoadScene (stagename);
	}

}