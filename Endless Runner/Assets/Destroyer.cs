using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {


    void OnTriggerEnter(Collider col)
    {

     //   Debug.Log(col.gameObject.name);
        Destroy(col.gameObject);
    }

    void OnCollisionEnter(Collision col)
    {

//        Debug.Log(col.gameObject.name);
        Destroy(col.gameObject);
    }
}
