using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HintText : MonoBehaviour {
	public GameObject hintpanel;
	private Text hintpaneltext;
	public AudioClip pausesound;
	private AudioSource audiosouce;

	// Use this for initialization
	void Start () {
		hintpaneltext = hintpanel.transform.GetChild (0).transform.GetChild (0).gameObject.GetComponent<Text> ();
		audiosouce = GetComponent<AudioSource> ();


	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void hintPush(){
		hintpanel.SetActive (true);
		audiosouce.PlayOneShot (pausesound);
		if (SceneManager.GetActiveScene ().name == "Gamescene") {
			hintpaneltext.text =
				"ここにテキストを表示            ここにテキストを表示          ここにテキストを表示";

		} else if (SceneManager.GetActiveScene ().name == "Stage1") {
			hintpaneltext.text = "スタートからゴールまでを目指すゲームです。\n左下のスティックから自機を動かしてゴールに触れてみましょう。";
		} else if (SceneManager.GetActiveScene ().name == "Stage2") {
			hintpaneltext.text = "レーザーに当たると自機は消滅しますが、 \nまたスタート地点から復活します。\nゴールできるまで何度もトライしてみましょう。";
		}else if(SceneManager.GetActiveScene ().name == "Stage3") {
			hintpaneltext.text = "「ブロック」はレーザーを遮断します。\nタップして置いてみましょう。";
		}else if(SceneManager.GetActiveScene ().name == "Stage4") {
			hintpaneltext.text = "「ブロック」をタップしたまま別の場所をタップすると、「ブロック」は回転します。";
		}else if(SceneManager.GetActiveScene ().name == "Stage5") {
			hintpaneltext.text = "「マグネット」は自機以外の動いているモノを\n止めることができます。";
		}else if(SceneManager.GetActiveScene ().name == "Stage7") {
			hintpaneltext.text = "「セーフティエリア」はレーザーを通り抜け\nられますが、遮断することはできません。";
		}else if(SceneManager.GetActiveScene ().name == "Stage8") {
			hintpaneltext.text = "「セーフティエリア」内では、アイテムの再配置ができます。\n「ブロック」を二回置いてみましょう。";
		}else if(SceneManager.GetActiveScene ().name == "Stage9") {
			hintpaneltext.text = "赤いレーザーは静止すると当たりません。\n青いレーザーは動いている間は当たりません。\n信号機をイメージしましょう。";
		}else{
			hintpaneltext.text = "なし";

		}

	}
}
