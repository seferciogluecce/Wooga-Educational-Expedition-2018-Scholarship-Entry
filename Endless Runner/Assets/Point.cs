using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //gameObject.tag = "Point";
	}
	
	// Update is called once per frame
	void Update () {

        
       
            transform.Translate(Vector3.down * Time.deltaTime);

        
    }
}
