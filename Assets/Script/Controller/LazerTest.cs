using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerTest : MonoBehaviour {
	public Vector3 startPosition;
	public Vector3 direction;
	public float distance;
	public LayerMask mask;

	private RaycastHit2D hitInfo;
	private LineRenderer line;

	// Use this for initialization
	void Start () {
		line = GetComponent<LineRenderer> ();
	   
	}
	
	// Update is called once per frame
	void Update () {
		//Lineの開始地点を登録
		line.SetPosition (0, startPosition);
		//Raycastを使って何かヒットしているかチェック
		hitInfo = Physics2D.Raycast(startPosition,direction,distance,mask);
		//何かにヒットしていたとき
		if (hitInfo.collider != null) {
			if (hitInfo.collider.tag == "PlayerTag"  ) {
				GameObject.Find ("PlayerManeger").GetComponent<PlayerManeger> ().InvokeRetornPlayer ();

			}
			line.SetPosition (1, hitInfo.point);
		}
		//何もヒットしなかったとき
		else {
			line.SetPosition (1, startPosition + (direction * distance));
		}
	}



}
