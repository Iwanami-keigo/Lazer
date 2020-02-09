using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Background : MonoBehaviour {
	Vector3 mouseworld;
	GameObject joystick;
	bl_Joystick joystickscript;
	GameObject canvas;

	RectTransform canvasrect;
	RectTransform recttransform;

	Vector2 firstpos;
	public bool itemcatch = false;
	// Use this for initialization
	void Start () {
	joystick = GameObject.Find ("Joystick");
		joystickscript = joystick.GetComponent<bl_Joystick> ();
		canvas	= GameObject.Find ("Canvas");

		recttransform = joystick.GetComponent<RectTransform> ();

		canvasrect = canvas.GetComponent<RectTransform> ();

		firstpos = recttransform.anchoredPosition;
	}
	
	// Update is called once per frame
	void Update () {
		mouseworld = Input.mousePosition;

	}
	public void pointerup(){
		joystickscript.OnPointerUp (new PointerEventData (EventSystem.current));
		recttransform.anchoredPosition = firstpos;
	}
	public void drag(){
        Debug.Log("backgrounddrag");
	
			joystickscript.OnDrag (new PointerEventData (EventSystem.current));

	
		
        Debug.Log("Backend");
	}
	public void dragstart(){
        Debug.Log("dragstarton");
		if (itemcatch == false) {

	





        
			if (Input.touchCount > 0) {
				Touch[] myTouches = Input.touches;

				Vector3 touchposition = myTouches [0].position;



			Vector3 viewportpos = Camera.main.ScreenToViewportPoint (touchposition);
        
				Vector2 ancherpos = new Vector2 (canvasrect.sizeDelta.x * viewportpos.x, canvasrect.sizeDelta.y * viewportpos.y);
				recttransform.anchoredPosition = ancherpos;

				joystickscript.Updatedeatharea ();
				joystickscript.OnPointerDown (new PointerEventData (EventSystem.current));

			} else if (Input.GetMouseButton (0)) {

				Vector3 mouseposition = mouseworld;
		


				Vector3 mouseviewpos = Camera.main.ScreenToViewportPoint (mouseposition);

				Vector2 mouseancherpos = new Vector2 (canvasrect.sizeDelta.x * mouseviewpos.x, canvasrect.sizeDelta.y * mouseviewpos.y);
				recttransform.anchoredPosition = mouseancherpos;

				joystickscript.Updatedeatharea ();
			   joystickscript.OnPointerDown (new PointerEventData (EventSystem.current));


			}


		}
        Debug.Log("dragstartoff");
}
}