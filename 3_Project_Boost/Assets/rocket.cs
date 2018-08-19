using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {
    [SerializeField] float rcsThrust = 150f;
    [SerializeField] float mainThrust = 100f;
    Rigidbody rigidBody;
    AudioSource RocketThrust;
	// Use this for initialization
	void Start () 
    {
        rigidBody = GetComponent<Rigidbody>();
        RocketThrust = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        Thrust();
        Rotate();
    }

     void OnCollisionEnter(Collision collision) //Manual for collisions: https://docs.unity3d.com/Manual/CollidersOverview.html
     { // API: https://docs.unity3d.com/ScriptReference/Collider.OnCollisionEnter.html
         switch (collision.gameObject.tag)
         {
             case "Friendly":
             print ("OK");
             break;
             case "Fuel":
             print("getting Fuel");
             break;
             default:
             print ("Dead");
             break;
         }
     }
    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space)) //Thruss and rotate at the same time
        {
            rigidBody.AddRelativeForce(Vector3.up * mainThrust);
            if (!RocketThrust.isPlaying)
            {
                RocketThrust.Play();
            }
        }
        else
        {
            RocketThrust.Stop();
        }
    }
    private void Rotate()
    {
        rigidBody.freezeRotation = true; //Take manual control of rotation
        
        float rotationThisFrame = rcsThrust * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }
       // rigidBody.freezeRotation = false; //Resume Physics
    }
}
