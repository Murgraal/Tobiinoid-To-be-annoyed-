﻿using System.Collections;
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
		_gazespot = Camera.main.ScreenToWorldPoint (_gazepoint.Screen);

		if (_gazepoint.IsValid && _gazepoint.IsWithinScreenBounds)
			GameManager.instance.spotchecker.transform.position = _gazespot;



	}
}
