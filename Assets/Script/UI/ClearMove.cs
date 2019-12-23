using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ClearMove : MonoBehaviour {
	Tweener tweener;
	public float y;
	public float time;
	public  Vector3 firstPosition;
	private GameObject Goal;

	// Use this for initialization
	void Start () {
		Goal = GameObject.Find ("Goal");
		firstPosition = this.gameObject.transform.position;


	}
	
	// Update is called once per frame
	void Update () {
		if (Goal.gameObject.tag == "GoalEnterTag") {
			Clear ();
		}

		
	}
	void Clear(){
		tweener = this.transform.DOLocalMove (new Vector3 (0, y, 0), time).SetEase (Ease.OutExpo);
	}
		
}
