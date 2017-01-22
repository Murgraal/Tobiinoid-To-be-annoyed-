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
		if (EyeTracking.GetFocusedObject ().name == "node")
		EyeTracking.GetFocusedObject ().GetComponent<Node> ().isActive = true;
		if (EyeTracking.GetFocusedObject ().name == "mini")
		GameManager.instance.upgrades = Upgrades.mini;
		if (EyeTracking.GetFocusedObject ().name == "mega")
		GameManager.instance.upgrades = Upgrades.mega;
		if (EyeTracking.GetFocusedObject ().name == "dubbel")
		GameManager.instance.upgrades = Upgrades.dubbel;
		if (EyeTracking.GetFocusedObject ().name == "nopower") 
		{	
			UpgradeManager.instance.removeball(GameObject.Find ("addedball"));
			GameManager.instance.upgrades = Upgrades.none;
		}
		if (EyeTracking.GetFocusedObject ().name == "speed")
		GameManager.instance.upgrades = Upgrades.speed;
		if (EyeTracking.GetFocusedObject ().name == "addballs")
		UpgradeManager.instance.addballs (GameManager.instance.addedball);
			
		
		}

	}
}
