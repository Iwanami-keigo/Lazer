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



    GameObject back;
    GameObject next;
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
		back = GameObject.Find ("BackButton");
		next = GameObject.Find ("NextButton");
		//バック親
		backred = back.GetComponent<Image> ().color.r;
		backgreen= back.GetComponent<Image> ().color.g;
		backblue = back.GetComponent<Image> ().color.b;
		backalfa = back.GetComponent<Image> ().color.a;
		//ネクスト親
		nextred = next.GetComponent<Image> ().color.r;
		nextgreen = next.GetComponent<Image> ().color.g;
		nextblue = next.GetComponent<Image> ().color.b;
		nextalfa = next.GetComponent<Image> ().color.a;

		//バック子
		backred2 = back.transform.GetChild(0).gameObject.GetComponent<Text> ().color.r;
		backgreen2 = back.transform.GetChild(0).gameObject.GetComponent<Text> ().color.g;
		backblue2 = back.transform.GetChild(0).gameObject.GetComponent<Text> ().color.b;
		backalfa2 = back.transform.GetChild(0).gameObject.GetComponent<Text> ().color.a;
		//ネクスト子
		nextred2 = next.transform.GetChild(0).gameObject.GetComponent<Text> ().color.r;
		nextgreen2 = next.transform.GetChild(0).gameObject.GetComponent<Text> ().color.g;
		nextblue2 = next.transform.GetChild(0).gameObject.GetComponent<Text> ().color.b;
		nextalfa2 = next.transform.GetChild(0).gameObject.GetComponent<Text> ().color.a;

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
		PlayerManeger.deadcount = 0;
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
            else if (SceneManager.GetActiveScene().name == "Stage30")
            {
                SceneManager.LoadScene("Stage31");
            }
            else if (SceneManager.GetActiveScene().name == "Stage31")
            {
                SceneManager.LoadScene("Stage32");
            }
            else if (SceneManager.GetActiveScene().name == "Stage32")
            {
                SceneManager.LoadScene("Stage33");
            }
            else if (SceneManager.GetActiveScene().name == "Stage33")
            {
                SceneManager.LoadScene("Stage34");
            }
            else if (SceneManager.GetActiveScene().name == "Stage34")
            {
                SceneManager.LoadScene("Stage35");
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
