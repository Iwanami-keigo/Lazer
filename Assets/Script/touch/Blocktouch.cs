using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocktouch : MonoBehaviour {

	float x;
	float y;
	//動ける範囲のｘとｙ
	float x_max = 6.9f;
	float x_min = -9.2f;
	float y_max = 4.2f;
	float y_min = -4.2f;
	private GameObject Block;
	public GameObject blockguide;

	private AudioSource audiosource;
	public AudioClip touchse;

	// Use this for initialization
	void Start () {
		Block = GameObject.Find ("Block");
		audiosource = GetComponent<AudioSource> ();

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

		if (Input.touchCount > 0 && tag == "BlocktouchNow") {
			Touch[] myTouches = Input.touches;
			for (int i = 1; i < myTouches.Length; i++) {
				if (i == 1) {
					Block.transform.Rotate (0, 0, 4);
				}
			}
		}
		if (tag == "BlocktouchNow") {
			blockguide.SetActive (true);
		} else {
			blockguide.SetActive (false);
		}
	}
	//無敵のうちだけアイテムを動かせる
	//イベントトリガー：ドラッグ
	public void Idou(){
		GameObject Player = GameObject.Find ("Player");
		if (Input.GetMouseButton (0)) {
			if (Player.tag == "InvincibleTag" || Player.tag == "StartPositionTag") {
				transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 10.0f));

			}
		}
		if (Input.touchCount > 0) {
			Touch[] myTouches = Input.touches;
			float touch_x;
			float touch_y;

			touch_x = myTouches [0].position.x;
			touch_y = myTouches [0].position.y;

			for (int i = 0; i < myTouches.Length; i++) {
				if (i == 0) {
					transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (touch_x, touch_y, 10.0f));
				}
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
	public void SE(){
		audiosource.PlayOneShot (touchse);
	}
}


