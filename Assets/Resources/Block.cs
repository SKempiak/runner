﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position -= new Vector3(0.25f,0,0);
        if(transform.position.x<-20){
            Destroy(gameObject);
        }
	}
}
