using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLab_Unload1stfloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
		GameObject Main_Camera = GameObject.Find("Main Camera");
		Main_Camera.transform.rotation = Quaternion.Euler(0, -90, 0);
        SceneManager.LoadScene("Lab 3 Room");
		Main_Camera.transform.position = new Vector3 (-738, 50, -2470);
    }
}
