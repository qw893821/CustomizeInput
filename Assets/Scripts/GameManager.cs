using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private static GameManager _instance;
    public static GameManager GM
    {
        get { return _instance; }
    }

    public string lKey;
    public string rKey;
    public string uKey;
    public string dKey;
	// Use this for initialization
	void Start () {
        if (_instance == null)
        {
            _instance = this;
        }
        else { Destroy(this); }
        //set default value of key
        lKey = "j";
        rKey = "l";
        uKey = "i";
        dKey = "k";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
