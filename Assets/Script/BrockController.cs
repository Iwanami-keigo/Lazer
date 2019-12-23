using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrockController : MonoBehaviour {

	float x;
	float y;
	//動ける範囲のｘとｙ
	float x_max = 8.4f;
	float x_min = -8.4f;
	float y_max = 4.9f;
	float y_min = -4.9f;
	private GameObject Player;
	private GameObject BlockTouch;
	public float z;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		BlockTouch = GameObject.Find ("Blocktouch");
	}

	// Update is called once per frame
	void Update () {
		Vector3 MGpo = transform.position;
		MGpo.x = Mathf.Clamp (transform.position.x, x_min, x_max);
		MGpo.y = Mathf.Clamp (transform.position.y, y_min, y_max);
		transform.position = new Vector3 (MGpo.x, MGpo.y, transform.position.z);

		x = Input.mousePosition.x;
		y = Input.mousePosition.y;

		if (Input.GetKey (KeyCode.Space) && BlockTouch.tag == "BlocktouchNow") {
			this.transform.Rotate (0, 0, z);
		}
			
		if (Player.gameObject.tag == "InvincibleTag" || Player.tag == "StartPositionTag") {
			Retorntouch ();

		}
		if (Player.gameObject.tag == "PlayerTag") {
			Dietouch ();
		}
	}
	//無敵のうちだけアイテムを動かせる

	void Dietouch(){
		BlockTouch.SetActive (false);
}
	void Retorntouch(){
		BlockTouch.SetActive (true);
	}
}



