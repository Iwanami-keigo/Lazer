using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenSpin : MonoBehaviour {

	public float Zrote ;
	public float theTime;
	Tweener tweener;
	// Use this for initialization
	void Start () {
		Zrote += transform.localEulerAngles.z;
		tweener = transform.DOLocalRotate (new Vector3 (0f, 0f, Zrote), theTime, RotateMode.FastBeyond360).SetEase (Ease.Linear).SetLoops (-1, LoopType.Restart).SetId (this);

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
