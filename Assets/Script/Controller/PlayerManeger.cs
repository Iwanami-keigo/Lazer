using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManeger : MonoBehaviour {

	public Vector3 firstPosition;
	private GameObject Player;
	//爆発演出のプレハブ
	public GameObject Explosion;
	//リスポーン演出〃
	public GameObject resporn;
	//爆発プレハブを入れるリスト
	private List<GameObject>boomPool = new List<GameObject>();
	//リスポーンプレハブ〃
	private List<GameObject>respool = new List<GameObject>();
	//プーリングする数
	private int boomnum = 1;
	private int resnum = 1;


	// Use this for initialization
	void Start () {
		//プレイヤーの初期位置
		Player = GameObject.Find ("Player");
		firstPosition = Player.transform.position;

		//爆発をインスタンス化
		GameObject bom;
		for (int i = 0; i < boomnum; i++) {
			bom = GameObject.Instantiate (Explosion);
			bom.SetActive (false);
			boomPool.Add (bom);
		}
		GameObject res;
		for (int i = 0; i < resnum; i++) {
			res = GameObject.Instantiate (resporn);
			res.SetActive (false);
			respool.Add (res);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void RetornPlayer(){
		
		Player.SetActive (true);
		Player.gameObject.tag = "StartPositionTag";
		Player.transform.position = firstPosition;



	}
	public void InvokeRetornPlayer(){
		bool isboom = false;
		for (int i = 0; i < boomPool.Count; i++) {
			if (!boomPool [i].activeSelf) {
		
				boomPool [i].transform.position = Player.transform.position;
			
				boomPool [i].SetActive (true);
				isboom = true;
				break;
			}
		}


		Player.SetActive (false);
		Invoke ("RespornEffect", 0.5f);
		Invoke ("RetornPlayer", 1.8f);
}
	void RespornEffect(){
		bool isres = false;
		for (int i = 0; i < respool.Count; i++) {
			if (!respool [i].activeSelf) {
				respool [i].transform.position = firstPosition;
				respool [i].SetActive (true);
				isres = true;
				break;
			}
		}
	}
}
