using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load1stfloor_unloadlab : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
		GameObject Main_Camera = GameObject.Find("Main Camera");
		Main_Camera.transform.rotation = Quaternion.Euler(0, 235, 0);
        SceneManager.LoadScene("North 1st Floor");
		Main_Camera.transform.position = new Vector3 (-1437, 50, -1213);
    }
}
