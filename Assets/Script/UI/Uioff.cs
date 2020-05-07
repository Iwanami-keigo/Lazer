using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Uioff : MonoBehaviour
{
    private GameObject retry;
    private GameObject joystick;
    private GameObject home;
    public GameObject hint;
    public GameObject skip;

    private bool downflag = false;
    Image image;
    private GameObject buttonimage;

    public Sprite on;
    public Sprite off;

    string[] stages;
    string nouwstage;
    // Use this for initialization
    void Start()
    {
        retry = GameObject.Find("Retry");
        joystick = GameObject.Find("Joystick");
        home = GameObject.Find("Homeback");
        buttonimage = transform.Find("Button").gameObject;
        image = buttonimage.GetComponent<Image>();
        stages = new string[] { "Stage1", "Stage2", "Stage3", "Stage4", "Stage5",  "Stage7", "Stage8", "Stage9" ,"Stage31"};

        nouwstage = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if(downflag == false)
        {
            image.sprite = on;
        }
        else
        {
            image.sprite = off;
        }
    }
    public void buttondown()
    {
        Debug.Log("押された");
         if(downflag == false)
        {
            retry.SetActive(false);
            joystick.SetActive(false);
            home.SetActive(false);
            hint.SetActive(false);
            skip.SetActive(false);
            downflag = true;
        }
        else
        {
            retry.SetActive(true);
            joystick.SetActive(true);
            home.SetActive(true);
           if(nouwstage != "Stage30")
            {
                skip.SetActive(true);
            }
            
            downflag = false;
            for (int i = 0; i < stages.Length; i++)
            {
              if(nouwstage == stages[i])
                {
                    hint.SetActive(true);
                }

            }
          
        }
    }
}
    


