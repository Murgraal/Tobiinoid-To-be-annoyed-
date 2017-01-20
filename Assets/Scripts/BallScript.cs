using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	private Rigidbody2D rigid;

	// Use this for initialization
	void Start () 
	{
		
		rigid = GetComponent<Rigidbody2D> ();
		rigid.AddForce (Vector2.left * 1, ForceMode2D.Impulse);	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
