using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour {
	private LazerTest lazer;
	public LayerMask mask;

	private RaycastHit2D hitInfo;
	private LineRenderer line;
	

	// Use this for initialization
	void Start () {
		lazer = GetComponent<LazerTest> ();
		line = GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		lazer.startPosition = this.transform.position;
		lazer.direction = this.transform.up;
		//Lineの開始地点を登録
		line.SetPosition (0, lazer.startPosition);
		//Raycastを使って何かヒットしているかチェック
		hitInfo = Physics2D.Raycast(lazer.startPosition,lazer.direction,lazer.distance,mask);
		//何かにヒットしていたとき
		if (hitInfo.collider != null) {
			if (hitInfo.collider.tag == "PlayerTag"  ) {
				GameObject.Find ("PlayerManeger").GetComponent<PlayerManeger> ().InvokeRetornPlayer ();

			}
			line.SetPosition (1, hitInfo.point);
		}
		//何もヒットしなかったとき
		else {
			line.SetPosition (1, lazer.startPosition + (lazer.direction * lazer.distance));
		}
	}

	}
