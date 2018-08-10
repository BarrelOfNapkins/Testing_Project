using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_South_Side : MonoBehaviour {
	private Camera Main_Camera;
	// Use this for initialization
	void Start () {
		Main_Camera = Camera.main;
	}
	private void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene("South_Side");
		Main_Camera.transform.position = new Vector3 (-64, 60, -34);
		//Main_Camera.transform.eulerAngles = new Vector3(0, 90, 0);
		//Main_Camera.transform.Rotate(0, 0, 45, Space.World);
	}
}
