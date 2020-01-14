using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartArea : MonoBehaviour {

	public GameObject joystick;
	public GameObject homeback;
	public GameObject retry;
	public GameObject hint;
	private GameObject player;

	float touchtimelimit = 2.0f;
	float longtouch;

	bool down = false;

	// Use this for initialization
	void Start () {
		
		player = GameObject.Find ("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (down == true) {
			if (Input.GetMouseButton (0) && player.tag != "PlayerTag") {
				longtouch += Time.deltaTime;
				if (longtouch >= touchtimelimit) {
					joystick.SetActive (false);
					homeback.SetActive (false);
					retry.SetActive (false);
					hint.SetActive (false);
					Invoke ("UIon", 10.0f);
				}
			}
		}
	}

	public void UIoff(){
		down = true;

	}
	private void UIon(){
		joystick.SetActive (true);
		homeback.SetActive (true);
		retry.SetActive (true);
		hint.SetActive (true);
		longtouch = 0f;
		down = false;
	}
}
