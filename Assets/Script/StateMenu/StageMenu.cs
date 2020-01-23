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

	public float scrool = 2081.7f - 1276.11f;
	public float x_pos = 2081.7f;



	// Use this for initialization
	void Start () {
		playbutton = GameObject.Find ("PlayButton");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Moveflag);
		if (playbutton.activeSelf) {
			activeposition ();
		} else {
			nonactiveposition ();
		}

		if (Moveflag == 0) {
			scroolMenu (x_pos);
		}
	}
	void activeposition(){
		tweener = this.transform.DOLocalMoveY (down, time).SetEase (Ease.OutExpo);
	}
	void nonactiveposition(){
		tweener = this.transform.DOLocalMoveY ( up, time).SetEase (Ease.OutExpo);
	}
	void scroolMenu(float nowposition){
		tweener = this.transform.DOLocalMoveX (nowposition, time).SetEase (Ease.OutExpo);

}
}
