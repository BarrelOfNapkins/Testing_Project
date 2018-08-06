using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_South_Side : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		GameObject Main_Camera = GameObject.Find("Main Camera");
		SceneManager.LoadScene("South_Side");
		Main_Camera.transform.position = new Vector3 (-64, 71, -34);
		//Main_Camera.transform.eulerAngles = new Vector3(0, 90, 0);
		Main_Camera.transform.Rotate(0, 0, 0, Space.World);
	}
}
