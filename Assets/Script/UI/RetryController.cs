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

	private bool retryButtonDown = false;
	// Use this for initialization
	void Start () {
		Goal = GameObject.Find ("Goal");
		Player = GameObject.Find ("Player");
		SafetyTouch = GameObject.Find ("Safetytouch");
	


	}
	
	// Update is called once per frame
	void Update () {
		if (!SafetyTouch.activeSelf ) {
			Upmove ();
		} else if(Goal.tag != "GoalEnterTag"){
			Downmove ();
		}
		if (retryButtonDown == true) {
			Debug.Log ("リセット");
			SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		}
	}
	void Downmove(){
		tweener = this.transform.DOLocalMoveX (down, time).SetEase (Ease.OutExpo);
	}
	void Upmove(){
		tweener = this.transform.DOLocalMoveX ( up, time).SetEase (Ease.OutExpo);
	}
	public void GetRetryButtonDown(){
		this.retryButtonDown = true;
	}
}

