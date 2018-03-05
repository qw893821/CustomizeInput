using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeKey : MonoBehaviour {
    Button btn;
    public Text text;
	// Use this for initialization
	void Start () {
        btn = transform.GetComponent<Button>();
        btn.onClick.AddListener(SetKey);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void SetKey()
    {
        GameManager.GM.ChangeKey();
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
        }
    }
}
