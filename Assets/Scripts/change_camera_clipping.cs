using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_camera_clipping : MonoBehaviour {
	private bool state_camera;
	private Camera Main_Camera;
	private StereoController the_script;
	// Use this for initialization
	void Start () {
		state_camera = false;
		Main_Camera = Camera.main;
		the_script = (StereoController) Main_Camera.GetComponent(typeof(StereoController));
	}
	
	// Update is called once per frame
	private void OnTriggerEnter(Collider other)
	{
		if (state_camera == false) {
			Main_Camera.farClipPlane = 500;
			state_camera = true;
			Debug.Log ("change to 150");
			//Main_Camera<StereoController>.UpdateStereoValues ();
			the_script.UpdateStereoValues ();
		} else {
			Main_Camera.farClipPlane = 2500;
			state_camera = false;
			Debug.Log ("change to 2500");
			//Main_Camera.StereoController.UpdateStereoValues ();
			the_script.UpdateStereoValues ();
		}
	}
}
