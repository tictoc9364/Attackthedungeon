﻿using UnityEngine;
using System.Collections;

public class RotateBox : MonoBehaviour {

    public float rotateX;
    public float rotateY;
    public float rotateZ;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(rotateX*Time.deltaTime, rotateY*Time.deltaTime, rotateZ*Time.deltaTime);
	}
}
