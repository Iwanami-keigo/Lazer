using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	//移動速度
	private float speed = 0.07f;

	//動ける範囲のｘとｙ
	float x_max = 8.4f;
	float x_min = -8.4f;
	float y_max = 4.9f;
	float y_min = -4.9f;

	private GameObject goal;


	// Use this for initialization
	void Start () {
		
		goal = GameObject.Find ("Goal");

		
	}
	
	// Update is called once per frame
	void Update () {
		
		//動ける範囲の制限
		Vector3 PlayerPosition = transform.position;
		PlayerPosition.x = Mathf.Clamp (transform.position.x, x_min, x_max);
		PlayerPosition.y = Mathf.Clamp (transform.position.y, y_min, y_max);
		transform.position = new Vector3 (PlayerPosition.x, PlayerPosition.y, transform.position.z);

		//上に移動
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(0,this.speed,0);
		}
		//下に移動
	 if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(0,-this.speed,0);
		}
		//右に移動
	if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(this.speed,0,0);
		}
		//左に移動
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(-this.speed,0,0);
		}
		if (goal.tag == "GoalEnterTag") {
			speed = 0;
		}

}
	void OnTriggerStay2D(Collider2D other){
		//Startエリア内に居る時は開始位置タグ
		if (other.gameObject.tag == "StartAreaTag") {
			
			gameObject.layer = LayerMask.NameToLayer ("Invincible");
			gameObject.tag = "StartPositionTag";
		}
	}
	//Safetyエリアに居る時は無敵タグ
	void OnTriggerEnter2D(Collider2D other){
		
		if (other.gameObject.tag == "SafetyTag" ) {
			gameObject.layer = LayerMask.NameToLayer("Invincible");
			gameObject.tag = "InvincibleTag";
		}
		if (other.gameObject.tag == "GoalEnterTag") {
			gameObject.layer = LayerMask.NameToLayer ("Invincible");
			gameObject.tag = "PlayerGoalTag";
		}

	}
    //両エリアから出たら無敵タグ（開始位置タグ）を解く
	void OnTriggerExit2D(Collider2D other){
		Debug.Log ("Exit");
		if (other.gameObject.tag == "SafetyTag" || other.gameObject.tag == "StartAreaTag") {
			gameObject.layer = LayerMask.NameToLayer("Player");
			gameObject.tag = "PlayerTag";
	}
	}

}
	
