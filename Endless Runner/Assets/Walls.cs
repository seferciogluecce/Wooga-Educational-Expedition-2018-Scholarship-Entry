using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour {
    int gameSpeed = 1;
    GameController gameController;
    int interval15 = 0;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * Time.deltaTime*gameSpeed);
        if (Time.timeSinceLevelLoad / 15 > interval15)
        {
            interval15++;
            gameSpeed += gameSpeed / 2;
        }
    }

}
