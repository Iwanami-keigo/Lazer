using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryController : MonoBehaviour {
	//ミニレーザーを入れる
	public GameObject MiniLazer;


	//発射地点
	public Transform Battery;
	//弾を飛ばす力（速さ）
	public float speed;
	//弾のオブジェクトを入れておくリスト
	private List<GameObject>bulletPoolObjs = new List<GameObject>();
	//最初にプーリングする数
	private int numOfPool = 60;

	//n秒ごとに処理を実行する
	public float timeOut;
	private float timeElapsed;

	// Use this for initialization
	void Start () {
		GameObject Lazers;
		for (int i = 0; i < numOfPool; i++) {
			Lazers = Instantiate (MiniLazer);
			Lazers.SetActive (false);
			bulletPoolObjs.Add (Lazers);
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		//n秒おきに発射する
		timeElapsed += Time.deltaTime;
		if(timeElapsed >= timeOut){　
        //弾に空きがあるか
			bool isGetObject = false;
			for(int i = 0;i<bulletPoolObjs.Count;i++){
				if(!bulletPoolObjs[i].activeSelf){
					bulletPoolObjs[i].transform.position = Battery.position;
					bulletPoolObjs[i].transform.position += Battery.up * 0.6f;
					bulletPoolObjs[i].transform.rotation = Battery.rotation;
					bulletPoolObjs [i].SetActive (true);
					Vector3 force;
					force = this.gameObject.transform.up * speed;

					//Rigidbodyに力を加えて発射
					bulletPoolObjs[i].GetComponent<Rigidbody2D>().AddForce(force,ForceMode2D.Impulse);

					isGetObject = true;
						break;
				}
			}
			//無かったら追加して発射
			if (!isGetObject) {
				var Lazers = GameObject.Instantiate (MiniLazer);
				Lazers.transform.position = Battery.position;
				Lazers.transform.position += Battery.up * 0.6f;
				Lazers.transform.rotation = Battery.rotation;
				bulletPoolObjs.Add (Lazers);
				Vector3 force;
				force = this.gameObject.transform.up * speed;

				//Rigidbodyに力を加えて発射
				Lazers.GetComponent<Rigidbody2D>().AddForce(force,ForceMode2D.Impulse);

			}
		

			//時間処理のリセット
			timeElapsed = 0.0f;
	}
}
}