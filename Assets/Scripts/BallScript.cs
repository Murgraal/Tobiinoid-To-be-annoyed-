using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	private Rigidbody2D rigid;
	public float _minvelocityx;
	public float _minvelocityy;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "centerhex") 
		{
			GameManager.instance.updateScore (100);
		}
		if (col.gameObject.tag == "innerhex") 
		{
			GameManager.instance.updateScore (50);
		}
		if (col.gameObject.tag == "outerhex")
		{
			GameManager.instance.updateScore (25);
		}

	}

	void Start () 
	{
		
		rigid = GetComponent<Rigidbody2D> ();
		rigid.AddForce (Vector2.left * 1, ForceMode2D.Impulse);	
	}
	
	// Update is called once per frame
}
