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

	private  Vector3 firstPosition;

	private GameObject Player;
	private GameObject Goal;
	private GameObject SafetyTouch;
	public GameObject homePanel;

	private bool retryButtonDown = false;
	private bool retryhome = false;

	private bool backhome = false;
	// Use this for initialization
	void Start () {
		Goal = GameObject.Find ("Goal");
		Player = GameObject.Find ("Player");
		SafetyTouch = GameObject.Find ("Safetytouch");



	}
	
	// Update is called once per frame
	void Update () {
		if (Player.tag != "StartPositionTag" ) {
			Upmove ();
		} else{
			Downmove ();
		}

	}
	void Downmove(){
		tweener = this.transform.DOLocalMoveX (down, time).SetEase (Ease.OutExpo);
	}
	void Upmove(){
		tweener = this.transform.DOLocalMoveX ( up, time).SetEase (Ease.OutExpo);
	}
	public void ReturnMenu(){
		homePanel.SetActive (true);
	}
	public void GetRetryButtonDown(){
		Debug.Log ("Get");
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

}

