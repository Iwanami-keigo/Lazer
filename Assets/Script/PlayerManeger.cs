using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManeger : MonoBehaviour {

	public Vector3 firstPosition;
	private GameObject Player;
	public GameObject Explosion;


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
		GameObject Boom = Instantiate (Explosion) as GameObject;
		Boom.transform.position = Player.transform.position;
		Explosion.gameObject.transform.position = Player.gameObject.transform.position;
		Boom.GetComponent<ParticleSystem> ().Play ();
		Player.SetActive (false);
		Invoke ("RetornPlayer", 1);
}
}
