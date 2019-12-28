using System.Collections;
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

	float red,green,blue,alfa;

	public GameObject back;
	public GameObject next;

	Color color;

	// Use this for initialization
	void Start () {
		goal = GameObject.Find ("Goal");

	}
	
	// Update is called once per frame
	void Update () {
		if (goal.tag == "GoalEnterTag") {
			live = true;
			 
		}
		if (live == true && die == false) {
			die = true;
			GetComponent<RectTransform> ().DOAnchorPosX (x, time).SetEase (Ease.OutBack).SetDelay (lag);
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
			SceneManager.LoadScene ("Stage1");
		}
	}
}
