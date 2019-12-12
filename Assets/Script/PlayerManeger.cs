using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManeger : MonoBehaviour {

	public Vector3 firstPosition;
	private GameObject Player;


	// Use this for initialization
	void Start () {
		//プレイヤーの初期位置

		Player = GameObject.Find ("Player");
		firstPosition = Player.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void RetornPlayer(){
		Player.SetActive (true);
		Player.transform.position = firstPosition;


	}
	public void InvokeRetornPlayer(){
		Player.SetActive (false);
		Invoke ("RetornPlayer", 1);
}
}
