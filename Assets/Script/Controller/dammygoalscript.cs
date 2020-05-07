using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dammygoalscript : MonoBehaviour {
    private GameObject goal;
	// Use this for initialization
	void Start () {
        goal = GameObject.Find("Goal");
        this.transform.position = goal.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
