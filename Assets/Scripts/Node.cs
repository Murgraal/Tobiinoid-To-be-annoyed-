using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
	public bool isActive;

    public GameObject wave;
	public float timer;
	public bool isrunning;
    
	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (isActive && !isrunning)
        {
			StartCoroutine (Pulse (1, 1f));
        }
	}

	public IEnumerator Pulse(int waveamount, float maxtime)
	{
		isrunning = true;
		float interval = maxtime / waveamount;
		for (int i = 0; i < waveamount; i++) 
		{
			GameObject temp = Instantiate ((GameObject)wave, transform.position,wave.transform.rotation);
			yield return new WaitForSeconds (interval);
		}
		isActive = false;
		yield return null;
		isrunning = false;
	}

}