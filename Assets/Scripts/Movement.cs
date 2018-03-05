using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    float speed = 5f;
    float x;
    float y;
    float z;
    // Use this for initialization
    void Start () {
        x = 0;
        y = 0;
        z = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 target;
        target = transform.position + MoveDirection();
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        print(target);
	}

    Vector3 MoveDirection()
    {
        if (Input.GetKey(GameManager.GM.lKey) || Input.GetKey(GameManager.GM.rKey))
        {
            if (Input.GetKey(GameManager.GM.lKey))
            {
                x = -1f;
            }
            if (Input.GetKey(GameManager.GM.rKey))
            {
                x = 1f;
            }
        }
        else { x = 0; }
        if (Input.GetKey(GameManager.GM.uKey) || Input.GetKey(GameManager.GM.dKey))
        {
            if (Input.GetKey(GameManager.GM.uKey))
            {
                z = 1f;
            }
            if (Input.GetKey(GameManager.GM.dKey))
            {
                z = -1f;
            }
        }
        else { z = 0; }
        return new Vector3(x, y, z);
    }
}
