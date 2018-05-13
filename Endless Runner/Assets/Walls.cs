using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour {
    int gameSpeed;
    GameController gameController;

	// Use this for initialization
	void Start () {



    }

    // Update is called once per frame
    void Update()
    {

        Vector3 move = transform.position + Vector3.down;
        transform.Translate(Vector3.down * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        


    }

}
