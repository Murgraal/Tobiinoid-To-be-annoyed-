﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour 
{
	public static UpgradeManager instance;
	// Use this for initialization

	void Awake()
	{
		if (instance == null)
			instance = this;
		if (instance != this)
			Destroy (gameObject);
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
