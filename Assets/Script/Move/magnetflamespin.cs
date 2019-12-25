using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class magnetflamespin : MonoBehaviour {

	private float Zrote = 360f;
	public float theTime;
	Tweener tweener;
	public GameObject magnet;

	// Use this for initialization
	void Start () {
		this.gameObject.transform.position = magnet.transform.position;
		Zrote += transform.localEulerAngles.z;
		tweener = transform.DOLocalRotate (new Vector3 (0f, 0f, Zrote), theTime, RotateMode.FastBeyond360).SetEase (Ease.Linear).SetLoops (-1, LoopType.Restart).SetId (this);

	}

	// Update is called once per frame
	void Update () {
		
	}
}