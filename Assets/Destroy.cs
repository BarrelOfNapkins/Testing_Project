using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

    public void Destroyer()
    {
        if (Input.touchCount > 3)
        {
            Application.Quit();
        }
    }
}
