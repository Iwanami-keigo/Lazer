using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowLazer : MonoBehaviour {
    public Vector3 startPosition;
    public Vector3 direction;
    public float distance;


    public LayerMask mask;

    private RaycastHit2D hitInfo;
    private LineRenderer line;
    public bool colorchange = false;

    private GameObject player;

    private PlayerController playercontroller;
    public Material Yellowcolor;
    public Material lazercolor;
    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        line = GetComponent<LineRenderer>();
        playercontroller = player.GetComponent<PlayerController>();
    }
	
	// Update is called once per frame
	void Update () {
        startPosition = this.transform.position;
        direction = this.transform.up;
        //Lineの開始地点を登録
        line.SetPosition(0, startPosition);
        //Raycastを使って何かヒットしているかチェック
        hitInfo = Physics2D.Raycast(startPosition, direction, distance, mask);
        //何かにヒットしていたとき
        if (colorchange == false)
        {
            if (hitInfo.collider != null)
            {
                if (hitInfo.collider.tag == "PlayerTag")
                {
                   
                    Invoke("colorC", 0.5f);


                }
                line.SetPosition(1, hitInfo.point);
            }
            //何もヒットしなかったとき
            else
            {
                line.SetPosition(1, startPosition + (direction * distance));
            }
        }
        else
        {
            if (hitInfo.collider != null)
            {
                if (hitInfo.collider.tag == "PlayerTag")
                {
                    GameObject.Find("PlayerManeger").GetComponent<PlayerManeger>().InvokeRetornPlayer();
                   


                }
                line.SetPosition(1, hitInfo.point);
            }
            //何もヒットしなかったとき
            else
            {
                line.SetPosition(1, startPosition + (direction * distance));
            }
        }
        if(player.tag == "StartPositionTag")
        {
            colorchange = false;
            line.material = Yellowcolor;
        }
        
    }

    void colorC()
    {
        colorchange = true;
        line.material = lazercolor;
    }
}
