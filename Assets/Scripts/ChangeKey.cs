using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeKey : MonoBehaviour {
    Button btn;
    public Text text;
    float delayTime;
    float delayTimer;
    bool trigger;
	// Use this for initialization
	void Start () {
        delayTime = 1.5f;
        delayTimer = 0;
        btn = transform.GetComponent<Button>();
        btn.onClick.AddListener(CKey);
        trigger = false;
	}
	
	// Update is called once per frame
	void Update () {
        SetKey();
    }
    
    void CKey()
    {  
        GameManager.GM.CallText();
        trigger = true;  
    }

    void SetKey()
    {
        if (trigger)
        {
            delayTimer += Time.fixedUnscaledDeltaTime;
        }
        if (delayTimer >= delayTime)
        {
            GameManager.GM.WaitKey();
            if (GameManager.GM.change)
            {
                text.text = GameManager.GM.newKey;
                switch (transform.parent.name)
                {
                    case "Left":
                        GameManager.GM.lKey = GameManager.GM.newKey;
                        break;
                    case "Right":
                        GameManager.GM.rKey = GameManager.GM.newKey;
                        break;
                    case "Up":
                        GameManager.GM.uKey = GameManager.GM.newKey;
                        break;
                    case "Down":
                        GameManager.GM.dKey = GameManager.GM.newKey;
                        break;
                }
                text.text = GameManager.GM.newKey;
                GameManager.GM.text.enabled = false;
                delayTimer = 0;
                trigger = false;
            }
        }
    }
}
