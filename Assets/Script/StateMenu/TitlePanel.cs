using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TitlePanel : MonoBehaviour {

	private float alfa = 1f;
	float red,green,blue;
	public float speed ;
	public bool panelon = false;

	// Use this for initialization
	void Start () {
		red = GetComponent<Image> ().color.r;
		green = GetComponent<Image> ().color.g;
		blue = GetComponent<Image> ().color.b;

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Image> ().color = new Color (red,green,blue, alfa);
		if(panelon == false){

			alfa -= speed;
			if(alfa <= 0.001f){
				this.gameObject.SetActive (false);
			}
		}else{
			alfa += speed;


	}
}
}
