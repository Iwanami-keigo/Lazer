using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryController : MonoBehaviour {
	Tweener tweener;
	public float down;
	public float up;
	public float time;
	private float PosX = -64.5f;
	private float PosY = -63f;
	private  Vector3 firstPosition;
	private GameObject Player;
	private GameObject SafetyTouch;

	private bool retryButtonDown = false;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		SafetyTouch = GameObject.Find ("Safetytouch");


	}
	
	// Update is called once per frame
	void Update () {
		if (!SafetyTouch.activeSelf) {
			Upmove ();
		} else {
			Downmove ();
		}
		if (retryButtonDown == true) {
			Debug.Log ("リセット");
			SceneManager.LoadScene ("Gamescene");
		}
	}
	void Downmove(){
		tweener = this.transform.DOLocalMoveY (down, time).SetEase (Ease.OutExpo);
	}
	void Upmove(){
		tweener = this.transform.DOLocalMoveY ( up, time).SetEase (Ease.OutExpo);
	}
	public void GetRetryButtonDown(){
		this.retryButtonDown = true;
	}
}

