using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.EyeTracking;

public class EyeTrackingManager : MonoBehaviour {

	public Vector2 _gazespot;
	public GazePoint _gazepoint;


	// Use this for initialization
	void Start () 
	{
		EyeTracking.Initialize ();
	}
	// Update is called once per frame
	void Update ()
	{
		_gazepoint = EyeTracking.GetGazePoint ();
		if  (_gazepoint != null && _gazepoint.IsValid && _gazepoint.IsWithinScreenBounds) 
		{	
			_gazespot = Camera.main.ScreenToWorldPoint (_gazepoint.Screen);
			transform.position = _gazespot;
		}

		if (EyeTracking.GetFocusedObject() != null)
		{
		EyeTracking.GetFocusedObject ().GetComponent<Node> ().isActive = true;
		}

	}
}
