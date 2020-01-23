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

	RectTransform menurect;
	public float posx;
	// Use this for initialization
	void Start () {
		playbutton = GameObject.Find ("PlayButton");
		stagemenu = GameObject.Find ("StageMenu");
		stagemenuScript = stagemenu.GetComponent<StageMenu> ();
		menurect = stagemenu.GetComponent<RectTransform> ();

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
		menurect.DOAnchorPos (new Vector2(posx,0), time);
		posx = posx - stagemenuScript.scrool;
		Debug.Log (posx);
	}
	public void leftbuttonpush(){
		menurect.DOAnchorPos(new Vector2 (posx, 0),time);
		posx = posx + stagemenuScript.scrool;
		Debug.Log (posx);
	}
}
