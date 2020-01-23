using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class LeftRightButon : MonoBehaviour {
	GameObject playbutton;
	Tweener tweener;
	public float down;
	public float up;
	public float time;

	GameObject stagemenu;
	StageMenu stagemenuScript;
	private bool flag = false;
	// Use this for initialization
	void Start () {
		playbutton = GameObject.Find ("PlayButton");
		stagemenu = GameObject.Find ("StageMenu");
		stagemenuScript = stagemenu.GetComponent<StageMenu> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		if (playbutton.activeSelf) {
			activeposition ();
		} else {
			nonactiveposition ();
		}
	}
	void activeposition(){
		tweener = this.transform.DOLocalMoveY (down, time).SetEase (Ease.OutExpo);
	}
	void nonactiveposition(){
		tweener = this.transform.DOLocalMoveY ( up, time).SetEase (Ease.OutExpo);
	}
	public void rightbuttonpush(){
		stagemenuScript.Moveflag = stagemenuScript.Moveflag + 1;
	}
	public void leftbuttonpush(){
		stagemenuScript.Moveflag = stagemenuScript.Moveflag - 1;
	}
}
