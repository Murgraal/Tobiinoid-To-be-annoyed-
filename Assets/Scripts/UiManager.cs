using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {

	public Text score;
	public Text time;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		score.text = "Score\n" + GameManager.instance.score.ToString("0");
		//time.text = "Time\n" + GameManager.instance.currentTime.ToString ("0.0");
	}
}
