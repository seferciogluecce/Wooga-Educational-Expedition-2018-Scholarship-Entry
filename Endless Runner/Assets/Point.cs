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

        

            Vector3 move = transform.position + Vector3.down;
            transform.Translate(Vector3.down * Time.deltaTime);

        
    }
}
