using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.name == "Car_6")
            this.transform.Translate(0, 0, 0.7f);
        else if (name == "Car_5")
            transform.Translate(0, 0, 0.69f);
	}
}
