using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_1st_floor_unload_south : MonoBehaviour {
	private Camera Main_Camera;
	// Use this for initialization
	void Start () {
		Main_Camera = Camera.main;
	}

	private void OnTriggerEnter(Collider other)
	{
		//Main_Camera.transform.rotation = Quaternion.Euler(0, 270, 0);
		SceneManager.LoadScene("North 1st Floor");
		Main_Camera.transform.position = new Vector3 (-1573, 60, -318);
	}
}
