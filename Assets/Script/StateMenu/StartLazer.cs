using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLazer : MonoBehaviour {
	public Vector3 startPosition;
	public Vector3 direction;
	public float distance;


	public LayerMask mask;

	private RaycastHit2D hitInfo;
	private LineRenderer line;
	private bool key = true;

	// Use this for initialization
	void Start () {
		line = GetComponent<LineRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {


		if (Input.anyKey) {
			key = false;
	
		} else {
			key = true;
		
		}

		startPosition = this.transform.position;
		direction = this.transform.up;
		//Lineの開始地点を登録
		line.SetPosition (0,startPosition);
		//Raycastを使って何かヒットしているかチェック
		hitInfo = Physics2D.Raycast (startPosition, direction, distance, mask);
		//何かにヒットしていたとき
		if (this.gameObject.tag == "BatteryTag") {
			if (hitInfo.collider != null) {
				
				line.SetPosition (1, hitInfo.point);
			}
			//何もヒットしなかったとき
			else {
				line.SetPosition (1, startPosition + (direction * distance));
			}
		}
		if(this.gameObject.tag =="LedBatteryTag"){
			if (hitInfo.collider != null) {
				
				line.SetPosition (1, hitInfo.point);
			}
			//何もヒットしなかったとき
			else {
				line.SetPosition (1, startPosition + (direction * distance));
			}
		}
		if(this.gameObject.tag =="BlueBatteryTag"){
			if (hitInfo.collider != null) {
				
					

				}
				line.SetPosition (1, hitInfo.point);
			}
			//何もヒットしなかったとき
			else {
				line.SetPosition (1,startPosition + (direction * distance));
			}
		}


	}

