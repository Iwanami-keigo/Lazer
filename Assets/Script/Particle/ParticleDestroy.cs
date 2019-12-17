using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}
	void OnEnable(){
		this.gameObject.GetComponent<ParticleSystem> ().Play ();
	}
	private void OnParticleSystemStopped(){
		this.gameObject.SetActive (false);

	}
}
