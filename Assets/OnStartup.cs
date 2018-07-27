using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnStartup : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.UnloadSceneAsync("North 1st Floor");
        SceneManager.UnloadSceneAsync("Lab 3 Room");
        SceneManager.UnloadSceneAsync("North 1st Floor South");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
