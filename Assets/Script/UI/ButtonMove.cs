﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ButtonMove : MonoBehaviour {
	private GameObject goal;
	Tween tween;

	public float x;
	public float rX;
	public float lag;
	public float time;
	public float time2;
	private bool live = false;
	private bool die = false;
	private bool push = false;



	public GameObject back;
	public GameObject next;
	public float speed = 0.02f;
	Color color;

	float backred,backgreen,backblue,nextred,nextgreen,nextblue;
	private float backalfa,nextalfa,backalfa2,nextalfa2;
	float backred2,backgreen2,backblue2,nextred2,nextgreen2,nextblue2;

	private AudioSource audiosource;
	public AudioClip backse;
	public AudioClip nextse;
	// Use this for initialization
	void Start () {
		goal = GameObject.Find ("Goal");

		//バック親
		backred = GetComponent<Image> ().color.r;
		backgreen= GetComponent<Image> ().color.g;
		backblue = GetComponent<Image> ().color.b;
		backalfa = GetComponent<Image> ().color.a;
		//ネクスト親
		nextred = GetComponent<Image> ().color.r;
		nextgreen = GetComponent<Image> ().color.g;
		nextblue = GetComponent<Image> ().color.b;
		nextalfa = GetComponent<Image> ().color.a;

		//バック子
		backred2 = transform.GetChild(0).gameObject.GetComponent<Text> ().color.r;
		backgreen2 = transform.GetChild(0).gameObject.GetComponent<Text> ().color.g;
		backblue2 = transform.GetChild(0).gameObject.GetComponent<Text> ().color.b;
		backalfa2 = transform.GetChild(0).gameObject.GetComponent<Text> ().color.a;
		//ネクスト子
		nextred2 = transform.GetChild(0).gameObject.GetComponent<Text> ().color.r;
		nextgreen2 = transform.GetChild(0).gameObject.GetComponent<Text> ().color.g;
		nextblue2 = transform.GetChild(0).gameObject.GetComponent<Text> ().color.b;
		nextalfa2 = transform.GetChild(0).gameObject.GetComponent<Text> ().color.a;

		audiosource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		//バック親
		back.GetComponent<Image>().color = new Color (backred,backgreen,backblue,backalfa);
		//バック子
		back.transform.GetChild(0).gameObject.GetComponent<Text> ().color = new Color (backred2,backgreen2,backblue2, backalfa2);
		//ネクスト親
		next.GetComponent<Image>().color = new Color (nextred,nextgreen,nextblue,nextalfa);
		//ネクスト子
		next.transform.GetChild(0).gameObject.GetComponent<Text> ().color = new Color (nextred2,nextgreen2,nextblue2, nextalfa2);
		if (goal.tag == "GoalEnterTag") {
			live = true;
			 
		}
		if (live == true && die == false) {
			die = true;
			GetComponent<RectTransform> ().DOAnchorPosX (x, time).SetEase (Ease.OutBack).SetDelay (lag);
		}
		if (back.tag == "Buttonnull") {
			
			nextalfa -= speed;
			nextalfa2 -= speed;
		}
		if (next.tag == "Buttonnull") {
			
			backalfa -= speed;
			backalfa2 -= speed;
		}

		
	}


	public void BackReturn(){
		if (back.tag != "Buttonnull" && next.tag != "Buttonnull") {
			tag = "Buttonnull";
			GetComponent<RectTransform> ().DOAnchorPosX (rX, time2).SetEase (Ease.InBack);
			Invoke ("Stagechange", time2 += 2f);
		}
	}
	void Stagechange(){
		if (back.tag == "Buttonnull") {
			
			SceneManager.LoadScene ("Menu");
		}
		if (next.tag == "Buttonnull") {
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
			}else if (SceneManager.GetActiveScene ().name == "Stage11") {
				SceneManager.LoadScene ("Stage12");
			}else if (SceneManager.GetActiveScene ().name == "Stage12") {
				SceneManager.LoadScene ("Stage13");
			}else if (SceneManager.GetActiveScene ().name == "Stage13") {
				SceneManager.LoadScene ("Stage14");
			}else if (SceneManager.GetActiveScene ().name == "Stage14") {
				SceneManager.LoadScene ("Stage15");
			}else if (SceneManager.GetActiveScene ().name == "Stage15") {
				SceneManager.LoadScene ("Stage16");
			}else if (SceneManager.GetActiveScene ().name == "Stage16") {
				SceneManager.LoadScene ("Stage17");
			}else if (SceneManager.GetActiveScene ().name == "Stage17") {
				SceneManager.LoadScene ("Stage18");
			}else if (SceneManager.GetActiveScene ().name == "Stage18") {
				SceneManager.LoadScene ("Stage19");
			}else if (SceneManager.GetActiveScene ().name == "Stage19") {
				SceneManager.LoadScene ("Stage20");
			}
		}
	}

	public void Bseflag(){
		audiosource.PlayOneShot (backse);
	}
	public void Nseflag(){
		audiosource.PlayOneShot (nextse);
	}

		
}
