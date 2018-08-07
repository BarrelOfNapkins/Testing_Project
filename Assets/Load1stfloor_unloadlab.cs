using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load1stfloor_unloadlab : MonoBehaviour
{
	private Camera Main_Camera;
    // Use this for initialization
    void Start()
    {
		Main_Camera = Camera.main;
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
		//Main_Camera.transform.rotation = Quaternion.Euler(0, 235, 0);
        SceneManager.LoadScene("North 1st Floor");
		Main_Camera.transform.position = new Vector3 (-1437, 60, -1213);
    }
}
