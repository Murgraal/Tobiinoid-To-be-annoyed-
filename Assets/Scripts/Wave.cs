using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    private float expandRate = 0.2f;
    private float aliveTime = 3.0f;

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(expandRate, expandRate, 0);

        aliveTime -= Time.deltaTime;

        // remove condition
        if (aliveTime <= 0)
        {
            Debug.Log("TIME TO DIE");

            Destroy();
        }
    }
}