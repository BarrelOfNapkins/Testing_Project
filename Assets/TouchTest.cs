using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Input.touchCount);
        if (Input.touchCount > 0)
        {
            Input.GetTouch(0);
            Application.Quit();
        }

	}
}
