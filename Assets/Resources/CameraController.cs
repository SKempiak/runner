using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        
        for (int i = 0; i < 200; i++) {
        //GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //obj.transform.position = new Vector3(i-14, 0, 0);
            GameObject prefab = (GameObject)Instantiate(Resources.Load("FloorBlock"), new Vector3(i-100, 0, 0),Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(System.DateTime.Now);
	}
}
