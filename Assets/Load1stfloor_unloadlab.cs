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
        Debug.Log("Entered");
        // SceneManager.UnloadSceneAsync("Lab 3 Room");
        // SceneManager.LoadScene("North 1st Floor", LoadSceneMode.Additive);
        SceneManager.LoadScene("North 1st Floor");
    }
}
