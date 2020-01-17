using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafetyController : MonoBehaviour {
	 float x;
	 float y;
	//動ける範囲のｘとｙ
	float x_max = 8.4f;
	float x_min = -8.4f;
	float y_max = 4.9f;
	float y_min = -4.9f;
	private GameObject Player;
	private GameObject SafetyTouch;


	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		SafetyTouch = GameObject.Find ("Safetytouch");

		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Player.tag == "StartPositionTag") {
			Retorntouch ();

		}
		else  {
			Dietouch ();
		}
	}
	//スタートエリア内のうちだけアイテムを動かせる

	void Retorntouch (){
		SafetyTouch.SetActive (true);

}
	void Dietouch(){
		SafetyTouch.SetActive (false);
	}
}
