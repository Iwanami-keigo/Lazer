using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HintText : MonoBehaviour {
	public GameObject hintpanel;
	private Text hintpaneltext;
	public AudioClip pausesound;
	private AudioSource audiosouce;

	// Use this for initialization
	void Start () {
		hintpaneltext = hintpanel.transform.GetChild (0).transform.GetChild (0).gameObject.GetComponent<Text> ();
		audiosouce = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void hintPush(){
		hintpanel.SetActive (true);
		audiosouce.PlayOneShot (pausesound);
		if (SceneManager.GetActiveScene ().name == "Gamescene") {
			hintpaneltext.text =
				"ここにテキストを表示            ここにテキストを表示          ここにテキストを表示";

		} else if (SceneManager.GetActiveScene ().name == "Stage1") {
			hintpaneltext.text = "スタートからゴールまでを目指すゲームです。\n左下のスティックから自機を動かしてゴールに触れてみましょう。";
		

		}else{
			hintpaneltext.text = "なし";

		}

	}
}
