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
            print(EyeTracking.GetFocusedObject().tag);
		if (EyeTracking.GetFocusedObject ().tag == "node")
		EyeTracking.GetFocusedObject ().GetComponent<Node> ().isActive = true;

            if (EyeTracking.GetFocusedObject().tag == "mini")
            {
                GameManager.instance.upgrades = Upgrades.mini;
                Destroy(EyeTracking.GetFocusedObject());
            }
            if (EyeTracking.GetFocusedObject().tag == "mega")
            {
                GameManager.instance.upgrades = Upgrades.mega;
                Destroy(EyeTracking.GetFocusedObject());
            }

            if (EyeTracking.GetFocusedObject().tag == "dubbel")
            {
                GameManager.instance.upgrades = Upgrades.dubbel;
                Destroy(EyeTracking.GetFocusedObject());
            }

		    if (EyeTracking.GetFocusedObject ().tag == "nopower") 
		    {	
			UpgradeManager.instance.removeball(GameObject.Find ("addedball"));
			GameManager.instance.upgrades = Upgrades.none;
                Destroy(EyeTracking.GetFocusedObject());
            }
            if (EyeTracking.GetFocusedObject().tag == "speed")
            {
                GameManager.instance.upgrades = Upgrades.speed;
                Destroy(EyeTracking.GetFocusedObject());
            }
            if (EyeTracking.GetFocusedObject().tag == "addballs")
            {
                UpgradeManager.instance.addballs(GameManager.instance.addedball);
                Destroy(EyeTracking.GetFocusedObject());
            }
			
		
		}

	}
}
