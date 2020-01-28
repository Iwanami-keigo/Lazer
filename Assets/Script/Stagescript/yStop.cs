using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class yStop : MonoBehaviour {
	Tweener tweener;
	public float theTime;
	public float y;

	// Use this for initialization
	void Start () {
		tweener = transform.DOLocalMoveY (y, theTime).SetEase (Ease.Linear);

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "MagnetTag") {
			tweener.Pause ();
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "MagnetTag") {
			tweener.Play ();
		}
	}

}
