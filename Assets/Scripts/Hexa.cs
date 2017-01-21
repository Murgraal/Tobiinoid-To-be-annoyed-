using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexa : MonoBehaviour 
{
	public float timer;
	public bool startvanish;
	private CircleCollider2D collider;
	private Animator anim;
	// Use this for initialization
	void Start () 
	{
		collider = GetComponent<CircleCollider2D> ();
		anim = GetComponent<Animator> ();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			Vanish ();
		}	
	}
	// Update is called once per frame

	void Vanish()
	{
		anim.SetTrigger ("Shrink");	
	}

	void Update () 
	{			
	}
}
