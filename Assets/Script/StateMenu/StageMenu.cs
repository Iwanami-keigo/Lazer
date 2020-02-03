using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class StageMenu : MonoBehaviour {
	GameObject playbutton;
	Tweener tweener;
	public float down;
	public float up;
	public float time;

	public int Moveflag = 0;

	public float scrool;
	RectTransform menurect;

	public float posx;

	Button Lbtn;
	Button Rbtn;
	GameObject leftbtn;
	GameObject rightbtn;
	AudioSource audiosource;
	public AudioClip pushse;

	// Use this for initialization
	void Start () {
		playbutton = GameObject.Find ("PlayButton");
		menurect = GetComponent<RectTransform> ();
		audiosource = GetComponent<AudioSource> ();
		leftbtn = GameObject.Find ("LeftButton");
		rightbtn = GameObject.Find ("RightButton");

		Lbtn = leftbtn.GetComponent<Button> ();
		Rbtn = rightbtn.GetComponent<Button> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		if (playbutton.activeSelf) {
			activeposition ();
		} else {
			nonactiveposition ();
		}

		if (Moveflag == 0) {
			Lbtn.interactable = false;
		} else {
			Lbtn.interactable = true;
		}

		if (Moveflag == 5) {
			Rbtn.interactable = false;
		} else {
			Rbtn.interactable = true;
		}
	
	}
	void activeposition(){
		tweener = this.transform.DOLocalMoveY (down, time).SetEase (Ease.OutExpo);
	}
	void nonactiveposition(){
		tweener = this.transform.DOLocalMoveY ( up, time).SetEase (Ease.OutExpo);
	}
	public void rightbuttonpush(){
		if (Moveflag < 5) {
			posx = posx - scrool;
			menurect.DOAnchorPos (new Vector2 (posx, 0), time);
			Moveflag += 1;
		
			audiosource.PlayOneShot (pushse);
		}
	}
	public void leftbuttonpush(){
		if(Moveflag > 0){
			audiosource.PlayOneShot (pushse);
		posx = posx + scrool;
		menurect.DOAnchorPos(new Vector2 (posx, 0),time);
			Moveflag -= 1;
		
	}

}
}
