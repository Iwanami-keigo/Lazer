using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageButton : MonoBehaviour {

	private string stagename;
	private GameObject panel;
	TitlePanel titlepanel;

	public int stage_num;
	public int stage_flagnumber;
	Image image;
	Button button;

	public Material startmaterial;
	public Material goalmaterial;

	private string clearon;
	AudioSource audiosource;
	public AudioClip pushse;
	// Use this for initialization
	void Start () {
		stagename = this.gameObject.name;
		panel = GameObject.Find ("StartPanel");
		titlepanel = panel.GetComponent<TitlePanel> ();

		stage_num = PlayerPrefs.GetInt ("STAGE", 1);
		clearon = PlayerPrefs.GetString (stagename,"");
		image = GetComponent<Image> ();
		button = GetComponent<Button> ();
		Debug.Log (clearon);
		audiosource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (stage_num >= stage_flagnumber) {

			image.raycastTarget = true;
			button.interactable = true;
		}
		if (stage_flagnumber <= stage_num) {
			if (clearon == "CLEAR") {
				image.material = goalmaterial;
			} else {
				image.material = startmaterial;

			}
		}
	}


	public void stagepush(){
		audiosource.PlayOneShot (pushse);
		panel.SetActive (true);
		titlepanel.panelon = true;
		Invoke ("stagechange", 3);
}
	public void stagechange(){
		SceneManager.LoadScene (stagename);
	}

}