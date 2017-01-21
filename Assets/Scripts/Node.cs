using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private bool isActive = false;
    private float spawnInterval = 3.0f;
    private float spawnTimer;

    public GameObject wave;
    
	// Use this for initialization
	void Start ()
    {
        isActive = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isActive)
        {
            spawnTimer -= Time.deltaTime;

            if (spawnTimer <= 0)
            {
                SpawnWave();
            }
        }
	}

    public void Activate()
    {
        isActive = true;

        //Debug.Log("Activate");
    }

    private GameObject SpawnWave()
    {
        spawnTimer = spawnInterval;

        wave = GameObject.Instantiate(wave as GameObject);
        wave.transform.position = transform.position;

        return wave;
    }
}