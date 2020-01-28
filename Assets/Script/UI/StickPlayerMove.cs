using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StickPlayerMove : MonoBehaviour {
	private GameObject player;
	//移動速度
	public float attach;
	private float speed = 0.05f;
	private RectTransform recttrans;
	private GameObject goal;

	bool cAtch = false;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		goal = GameObject.Find ("Goal");
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 pos = GetComponent<RectTransform> ().anchoredPosition;
		if (Input.GetMouseButton(0)) {
			cAtch = true;
		} else {
			cAtch = false;
		}

		if (pos.x < 25f && pos.x >= 15f &&  cAtch == true) {
			player.transform.Translate (this.speed/2, 0, 0);
		}	
		if(pos.x > -25f&& pos.x <= -15f && cAtch == true ){
			player.transform.Translate (-this.speed/2, 0, 0);

		}
		if(pos.y < 25f&& pos.y >= 15f&& cAtch == true ){
			player.transform.Translate (0, this.speed/2, 0);
		}
		if (pos.y > -25f &&pos.y <= -15f && cAtch == true) {
			player.transform.Translate (0, -this.speed, 0);
		}











		if (pos.x >= 25f && cAtch == true) {
			player.transform.Translate (this.speed, 0, 0);
		}	
		if(pos.x <= -25f&& cAtch == true ){
			player.transform.Translate (-this.speed, 0, 0);
		
	}
		if(pos.y >= 25f&& cAtch == true ){
			player.transform.Translate (0, this.speed, 0);
		}
		if(pos.y <= -25f&& cAtch == true ){
			player.transform.Translate (0, -this.speed, 0);
		}
		if (goal.tag == "GoalEnterTag") {
			speed = 0;
		}

}

}

