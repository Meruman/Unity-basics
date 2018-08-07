using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {
    Rigidbody rigidBody;
    AudioSource RocketThrust;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        RocketThrust = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space)) //Thruss and rotate at the same time
        {
            rigidBody.AddRelativeForce(Vector3.up);
            if (!RocketThrust.isPlaying)
            {
                RocketThrust.Play();
            }
        }
        else
        {
            RocketThrust.Stop();
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward);
        }
    }
}
