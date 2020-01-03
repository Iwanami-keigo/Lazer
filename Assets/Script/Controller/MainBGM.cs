using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBGM : MonoBehaviour {

	public bool DontDestroyEnabled = true;

	// Use this for initialization
	void Start () {
		if (DontDestroyEnabled) {
			//シーン偏移してもBGMを続ける
			DontDestroyOnLoad (this);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void Awake(){
		int numMusicPlayers = FindObjectsOfType<MainBGM> ().Length;
		if (numMusicPlayers > 1) {
			Destroy (gameObject);
		} else {
			DontDestroyOnLoad (gameObject);
		}
	}

}
