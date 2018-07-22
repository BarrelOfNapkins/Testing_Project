using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dont_destroy : MonoBehaviour {
    private bool created = false;
    // Use this for initialization
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
