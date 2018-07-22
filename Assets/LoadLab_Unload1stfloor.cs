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
        Debug.Log("lab 3 load please");
// SceneManager.UnloadSceneAsync("North 1st Floor");
// SceneManager.LoadScene("Lab 3 Room", LoadSceneMode.Additive);
        SceneManager.LoadScene("Lab 3 Room");
    }
}
