using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    GameController gameController;
	// Use this for initialization
	void Start () {
        gameController = FindObjectOfType<GameController>();
	}

	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {
            //Debug.Log( Camera.main.ScreenToWorldPoint(Input.mousePosition));
            transform.position = Vector3.Lerp(transform.position, new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x , transform.position.y),1);
           // transform.Translate(new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y));

        }


	}

    //void OnCollisionEnter(Collision col)
    //{

    //    string colTag = col.gameObject.tag;
    //    Debug.Log(colTag);
    //    if (colTag == "WallPart")
    //    {
    //        gameController.GameOver();


    //    }
    //   else if (colTag == "Wall")
    //    {
    //        gameController.UpdateScore(50);

    //    }
    //    else if (colTag == "Point")
    //    { 
    //        gameController.UpdateScore(100);
    //        Destroy(col.gameObject);
    //    }


    //}


    void OnTriggerEnter(Collider col)
    {

        string colTag = col.gameObject.tag;
        if (colTag == "WallPart")
        {
            gameController.GameOver();


        }
        else if (colTag == "WallMiddle")
        {
            gameController.UpdateScore(50);

        }
        else if (colTag == "Point")
        {
            gameController.UpdateScore(100);
            Destroy(col.gameObject);
        }


    }

}
