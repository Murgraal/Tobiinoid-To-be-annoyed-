using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] spawns;
	public float timer,cooldown;
	public Transform[] spawnpoints;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		if (timer < 0) 
		{
			spawn (spawns[Random.Range(0,spawns.Length)],spawnpoints[Random.Range(0,spawnpoints.Length)]);
			timer = cooldown;
		}
	}
	void spawn(GameObject upgrade,Transform spawnlocation)
	{
		Instantiate ((GameObject)upgrade, spawnlocation.position,Quaternion.identity);
	}
}
