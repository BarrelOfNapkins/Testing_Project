using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLab_Unload1stfloor : MonoBehaviour {
	private Camera Main_Camera;
	// Use this for initialization
	void Start () {
		Main_Camera = Camera.main;
	}
	// Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
		//Main_Camera.transform.rotation = Quaternion.Euler(0, 270, 0);
        SceneManager.LoadScene("Lab 3 Room");
		Main_Camera.transform.position = new Vector3 (-1406, 60, -2511);
    }
}
