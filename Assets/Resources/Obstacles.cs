using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {
    int timer = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        timer++;
        if(timer>100){
            timer = 0;
            GameObject prefab = (GameObject)Instantiate(Resources.Load("Cube"), new Vector3(20, 1, 0), Quaternion.identity); 
        }

	}
}
