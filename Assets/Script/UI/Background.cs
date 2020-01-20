using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour {
	Vector3 mouseworld;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mouseworld = Input.mousePosition;

	}
	public void drag(){
		if (Input.touchCount > 0) {
			
			Touch[] myTouches = Input.touches;
		

			Vector3 screenpos = myTouches [0].position;



			Vector3 worldpos = Camera.main.ScreenToWorldPoint (screenpos);
			Vector3 viewpos = Camera.main.ScreenToViewportPoint (screenpos);
			for (int i = 0; i < myTouches.Length; i++) {
				if (i >= 0) {
					Debug.Log (viewpos);

				}
			}

		}

		if(Input.GetMouseButton(0)){
			
			Vector3 mouseworldpos = Camera.main.ScreenToWorldPoint (mouseworld);

			Vector3 mouseview = Camera.main.ScreenToViewportPoint (mouseworld);
			Debug.Log(mouseview);
		}
	}
	public void dragstart(){
		GameObject joystick = GameObject.Find ("Joystick");
		GameObject canvas = GameObject.Find ("Canvas");
	
		bl_Joystick joystickscript;


		RectTransform canvasrect;
		RectTransform recttransform;

		joystickscript = joystick.GetComponent<bl_Joystick> ();

		recttransform = joystick.GetComponent<RectTransform> ();

		canvasrect = canvas.GetComponent<RectTransform> ();


		if (Input.touchCount > 0) {
			Touch[] myTouches = Input.touches;

			Vector3 touchposition = myTouches [0].position;



			Vector3 viewportpos = Camera.main.ScreenToViewportPoint (touchposition);

			Vector2 ancherpos = new Vector2 (canvasrect.sizeDelta.x * viewportpos.x, canvasrect.sizeDelta.y * viewportpos.y);
			recttransform.anchoredPosition = ancherpos;

			joystickscript.Updatedeatharea ();
		}

		if(Input.GetMouseButton(0)){

			Vector3 mouseposition = mouseworld;



			Vector3 mouseviewpos =  Camera.main.ScreenToViewportPoint (mouseposition);

			Vector2 mouseancherpos = new Vector2 (canvasrect.sizeDelta.x * mouseviewpos.x, canvasrect.sizeDelta.y * mouseviewpos.y);
			recttransform.anchoredPosition = mouseancherpos;

			joystickscript.Updatedeatharea ();
	}



}
}