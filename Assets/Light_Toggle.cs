using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Toggle : MonoBehaviour {
    private bool light_status = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Toggle_Light()
    {
        if (Input.touchCount == 2)
        {
            this.GetComponent<Light>().enabled = !light_status;
            light_status = !light_status;
        }
    }
}
