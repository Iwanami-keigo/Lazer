using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SkipController : MonoBehaviour {
	public GameObject skipPanel;
	public AudioClip pausesound;
	private AudioSource audiosouce;
	private GameObject playermaneger;
	PlayerManeger manegerscript;

	float time = 0.02f;

	// Use this for initialization
	void Start () {
		audiosouce = GetComponent<AudioSource> ();
		playermaneger = GameObject.Find ("PlayerManeger");
		manegerscript = playermaneger.GetComponent<PlayerManeger> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (manegerscript.deadcount >= 7) {
			GetComponent<RectTransform> ().DOAnchorPosX (-100, time).SetEase (Ease.Linear);
		}
		
	}
	public void skipbuttondown(){
		skipPanel.SetActive (true);
		audiosouce.PlayOneShot (pausesound);
	}
}
