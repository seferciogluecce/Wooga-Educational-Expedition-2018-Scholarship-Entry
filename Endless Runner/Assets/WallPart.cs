﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPart : MonoBehaviour {
    GameController gameController;

    // Use this for initialization
    void Start () {
        gameController = FindObjectOfType<GameController>();

    }

    // Update is called once per frame
    void Update () {
		
	}


    private void OnCollisionEnter(Collision collision)
    {


     /*   if(collision.transform.tag=="Character")
            gameController.GameOver();
  */

    }
}
