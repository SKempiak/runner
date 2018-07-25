using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    float jump = 200;
    float speed = 0.05f;
    Rigidbody2D rb;
    // Use this for initialization
	void Start () {
         rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(new Vector3(0, jump, 0));
        } if(Input.GetKey(KeyCode.A)){
       this.transform.position += new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(speed, 0, 0);
        }
    }
}