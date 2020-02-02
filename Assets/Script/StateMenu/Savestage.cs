using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Savestage : MonoBehaviour {

	public int stage_num;

	public GameObject stage2;
	public GameObject stage3;
	public GameObject stage4;
	public GameObject stage5;
	public GameObject stage6;
	public GameObject stage7;
	public GameObject stage8;
	public GameObject stage9;
	public GameObject stage10;
	public GameObject stage11;
	public GameObject stage12;
	public GameObject stage13;
	public GameObject stage14;
	public GameObject stage15;
	public GameObject stage16;
	public GameObject stage17;
	public GameObject stage18;
	public GameObject stage19;
	public GameObject stage20;
	public GameObject stage21;
	public GameObject stage22;
	public GameObject stage23;
	public GameObject stage24;
	public GameObject stage25;
	public GameObject stage26;
	public GameObject stage27;
	public GameObject stage28;
	public GameObject stage29;
	public GameObject stage30;

	Image image;
	Button button;
	// Use this for initialization
	void Start () {
		stage_num = PlayerPrefs.GetInt ("CLERE", 0);
		image = GetComponent<Image> ();
		button = GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
