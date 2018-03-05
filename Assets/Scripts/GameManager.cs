﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    private static GameManager _instance;
    public static GameManager GM
    {
        get { return _instance; }
    }
    List<string> keys;
    public string lKey;
    public string rKey;
    public string uKey;
    public string dKey;
    public string newKey;
    public bool change;
    public GameObject textgo;
    public Text text;
    Event e;
	// Use this for initialization
	void Start () {
        if (_instance == null)
        {
            _instance = this;
        }
        else { Destroy(this); }
        //set default value of key
        keys = new List<string>();
        lKey = "j";
        keys.Add(lKey);
        rKey = "l";
        keys.Add(rKey);
        uKey = "i";
        keys.Add(uKey);
        dKey = "k";
        keys.Add(dKey);
        text = textgo.GetComponent<Text>();
        text.enabled = false;
        change = false;
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
        PUPgame();
    }

    public void CallText()
    {
        text.enabled = true;
        text.text = "Press Key To Set";
        
    }

    void PUPgame()
    {
        if (text.enabled)
        {
            Time.timeScale = 0;
        }
        if (!text.enabled)
        {
            Time.timeScale = 1;
        }
    }
    private void OnGUI()
    {
        e = Event.current;
    }

    public void WaitKey()
    {
        if (text.enabled)
        {
            if (e.isKey)
            {
                newKey = Input.inputString;
                if (newKey.Length > 1)
                {
                    newKey.Remove(1);
                    print("remove");
                }
                if (newKey != null)
                {
                    
                    foreach (string str in keys)
                    {
                        if (newKey == str)
                        {
                            text.text = "Key have used, please set new key";
                        }
                        else
                        { change = true;}
                    }
                    print(newKey);
                }
            }
        }
    }

}
