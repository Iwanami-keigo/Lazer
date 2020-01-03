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
	float red,green,blue,alfa;
	public float speed ;


	private GameObject back;
	private GameObject next;

	bool flagclear = false;
	// Use this for initialization
	void Start () {
		Goal = GameObject.Find ("Goal");
		firstPosition = this.gameObject.transform.position;
		back = GameObject.Find ("BackButton");
		next = GameObject.Find ("NextButton");
		red = GetComponent<Text> ().color.r;
		green = GetComponent<Text> ().color.g;
		blue = GetComponent<Text> ().color.b;
		alfa = GetComponent<Text> ().color.a;

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().color = new Color (red,green,blue, alfa);
			if (Goal.gameObject.tag == "GoalEnterTag" && flagclear == false) {
			tweener = this.transform.DOLocalMove (new Vector3 (0, y, 0), time).SetEase (Ease.OutExpo);
			flagclear = true;

		}
		if (back.tag == "Buttonnull" || next.tag == "Buttonnull") {
			alfa -= speed;
		}
		
	}

}
