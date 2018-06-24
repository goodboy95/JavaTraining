using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (name == "Car_1")
            transform.Translate(0, 0, Input.GetAxis("Vertical"));
        else
            transform.Translate(-Input.GetAxis("Vertical"), 0, 0);
    }
}
