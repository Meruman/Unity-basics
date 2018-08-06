using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space)) //Thruss and rotate at the same time
        {
            print("Space pressed");
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("rotate left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Rotate right");
        }
    }
}
