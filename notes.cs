/*
Game engine consists of : 
- Graphics Engine 
- Sound Engine 
- Scene manager 
and more 

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject Me;
    Transform t = null;
	// Use this for initialization
    // Unity function names are always capitalized 
	void Start () {
        t = Me.transform;

        GameObject cube = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = t.localPosition; // 3D array
        position.x += .5f;
        t.transform.localPosition = position;
	}
}

/*

*/


