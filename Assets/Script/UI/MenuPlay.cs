using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPlay : MonoBehaviour {

	private float alfa = 0f;
	float red,green,blue;
	float red2,green2,blue2;

	private float nexttime;
	//点滅周期
	public float interval ;
	private Image imagecolor;
	private Text textcolor;
	private GameObject panel;

	private bool colorflag = true;


	// Use this for initialization
	void Start () {
		red = GetComponent<Image> ().color.r;
		green = GetComponent<Image> ().color.g;
		blue = GetComponent<Image> ().color.b;

		red2 = transform.GetChild(0).gameObject.GetComponent<Text> ().color.r;
		green2 = transform.GetChild(0).gameObject.GetComponent<Text> ().color.g;
		blue2 = transform.GetChild(0).gameObject.GetComponent<Text> ().color.b;


		nexttime = Time.time;
		panel = GameObject.Find ("Panel");
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Image> ().color =  new Color (red,green,blue, alfa);
		transform.GetChild(0).gameObject.GetComponent<Text> ().color = new Color (red2,green2,blue2, alfa);
		if(!panel.activeSelf){
			nexttime += Time.deltaTime * interval;
			if (colorflag) {
				alfa -= nexttime;
				if (alfa < 0) {
					alfa = 0;
					colorflag = false;
					nexttime = 0;
				}
			} else {
				alfa += nexttime;
				if (alfa >= 1) {
					alfa = 1;
					colorflag = true;
					nexttime = 0;
				}
			}

	}
	}
}

