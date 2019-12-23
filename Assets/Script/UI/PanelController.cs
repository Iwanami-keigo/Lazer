using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour {

	private GameObject goal;
	private float alfa = 0f;
	float red,green,blue;
	public float speed = 0.01f;


	// Use this for initialization
	void Start () {
		goal = GameObject.Find ("Goal");
		red = GetComponent<Image> ().color.r;
		green = GetComponent<Image> ().color.g;
		blue = GetComponent<Image> ().color.b;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Image> ().color = new Color (red,green,blue, alfa);
		if(goal.tag == "GoalEnterTag"  && alfa <= 0.8f){

				alfa += speed;

	
}
}
}