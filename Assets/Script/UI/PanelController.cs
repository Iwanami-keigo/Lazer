using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelController : MonoBehaviour {

	private GameObject goal;
	private float alfa = 1f;
	float red,green,blue;
	public float speed ;
	private GameObject back;
	private GameObject next;

	public GameObject Homeback;
	public bool skipflag = false;


	// Use this for initialization
	void Start () {
		goal = GameObject.Find ("Goal");
		red = GetComponent<Image> ().color.r;
		green = GetComponent<Image> ().color.g;
		blue = GetComponent<Image> ().color.b;

		back = GameObject.Find ("BackButton");
		next = GameObject.Find ("NextButton");
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Image> ().color = new Color (red,green,blue, alfa);
		if (skipflag == false) {
			if (goal.tag != "GoalEnterTag" && Homeback.tag != "Buttonnull") {
				alfa -= speed;
				if (alfa <= 0.001f) {
					this.gameObject.SetActive (false);
				}
			}

			if (goal.tag == "GoalEnterTag" && alfa <= 0.5f) {
			
				alfa += speed;

	
			}
			if (back.tag == "Buttonnull" || next.tag == "Buttonnull" || Homeback.tag == "Buttonnull") {
				alfa += speed;
			}
		} else {
			alfa += speed;
		}

}
}