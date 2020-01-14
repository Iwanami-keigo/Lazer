using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void drag(){
		if (Input.touchCount > 0) {
			Debug.Log ("koko");
			Touch[] myTouches = Input.touches;
			float touch_x;
			float touch_y;

			Vector3 screenpos = myTouches [0].position;



			Vector3 worldpos = Camera.main.ScreenToWorldPoint (screenpos);

			for (int i = 0; i < myTouches.Length; i++) {
				if (i >= 0) {
					Debug.Log (worldpos);

				}
			}

		}
	}

}
