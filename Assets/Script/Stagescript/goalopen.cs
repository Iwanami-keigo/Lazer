using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalopen : MonoBehaviour {
    private GameObject yellowlazer;
    private GameObject goal;
    private YellowLazer yellowscript;
	// Use this for initialization
	void Start () {
        yellowlazer = GameObject.Find("YellowLazer");
        goal = GameObject.Find("Goal");
        yellowscript = yellowlazer.GetComponent<YellowLazer>();
    }
	
	// Update is called once per frame
	void Update () {
		if(yellowscript.colorchange == false)
        {
            goal.SetActive(false);
        }
        else
        {
            goal.SetActive(true);
        }
	}
}
