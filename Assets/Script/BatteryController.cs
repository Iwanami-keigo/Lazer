using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryController : MonoBehaviour {
	//ミニレーザーを入れる
	public GameObject MiniLazer;


	//発射地点
	public Transform Battery;
	//速度
	public float speed;


	//n秒ごとに処理を実行する
	public float timeOut;
	private float timeElapsed;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		//n秒おきに発射する
		timeElapsed += Time.deltaTime;
		if(timeElapsed >= timeOut){
			
　　　　//ミニレーザーの複製
			GameObject Lazers = Instantiate (MiniLazer) as GameObject;
			Vector3 force;
			force = this.gameObject.transform.up * speed;

			//Rigidbodyに力を加えて発射
			Lazers.GetComponent<Rigidbody2D>().AddForce(force,ForceMode2D.Impulse);


			//レーザーの位置調整
			Lazers.transform.position = Battery.position;
			Lazers.transform.position += Battery.up * 0.6f;

			//レーザーの角度調整
			Lazers.transform.rotation = Battery.rotation;


		

			//時間処理のリセット
			timeElapsed = 0.0f;
	}
}
}