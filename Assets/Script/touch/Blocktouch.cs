using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocktouch : MonoBehaviour {

	float x;
	float y;
	//動ける範囲のｘとｙ
	float x_max = 8f;
	float x_min = -8f;
	float y_max = 4.9f;
	float y_min = -4.9f;
	private GameObject Block;


	// Use this for initialization
	void Start () {
		Block = GameObject.Find ("Block");

	}

	// Update is called once per frame
	void Update () {
		
		Vector3 MGpo = transform.position;
		MGpo.x = Mathf.Clamp (transform.position.x, x_min, x_max);
		MGpo.y = Mathf.Clamp (transform.position.y, y_min, y_max);
		transform.position = new Vector3 (MGpo.x, MGpo.y, transform.position.z);

		x = Input.mousePosition.x;
		y = Input.mousePosition.y;

		Block.transform.position = this.gameObject.transform.position;


		if (Input.GetMouseButtonUp (0)) {
			this.gameObject.tag = "BlocktouchAgo";
		}
	}
	//無敵のうちだけアイテムを動かせる
	public void Idou(){
		GameObject Player = GameObject.Find ("Player");
		if (Input.GetMouseButton (0)) {
			if (Player.tag == "InvincibleTag" || Player.tag == "StartPositionTag") {
				transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 10.0f));
			
			}
		}



		}



	public void drop(){
		this.gameObject.tag = "BlocktouchAgo";
	}
	public void tagchange(){
		GameObject Player = GameObject.Find ("Player");
		if(Player.tag != "PlayerTag"){
		this.gameObject.tag = "BlocktouchNow";
	}
}
}


