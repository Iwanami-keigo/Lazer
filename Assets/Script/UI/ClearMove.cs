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
	float red,green,blue;
	public float speed ;
	private float alfa = 1f;

	private GameObject back;
	private GameObject next;
	// Use this for initialization
	void Start () {
		Goal = GameObject.Find ("Goal");
		firstPosition = this.gameObject.transform.position;
		back = GameObject.Find ("BackButton");
		next = GameObject.Find ("NextButton");


	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().color = new Color (red,green,blue, alfa);
		if (Goal.gameObject.tag == "GoalEnterTag") {
			
			Clear ();
		}
		if (back.tag == "Buttonnull" || next.tag == "Buttonnull") {
			alfa -= speed;
		}
		
	}
	void Clear(){
		tweener = this.transform.DOLocalMove (new Vector3 (0, y, 0), time).SetEase (Ease.OutExpo);
	}
		
}
