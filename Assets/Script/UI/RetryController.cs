using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryController : MonoBehaviour {
	
	public float down;
	public float up;
	public float time;

	private  Vector3 firstPosition;

	public GameObject homePanel;


	private bool retryButtonDown = false;
	private bool retryhome = false;

	private bool backhome = false;
	public AudioClip pausesound;
	private AudioSource audiosouce;

	// Use this for initialization
	void Start () {
		audiosouce = GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	public void ReturnMenu(){
		homePanel.SetActive (true);
		audiosouce.PlayOneShot (pausesound);
	}
	public void GetRetryButtonDown(){
		Debug.Log ("Get");
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

}

