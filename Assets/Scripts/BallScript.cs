using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	private Rigidbody2D rigid;
	public float _minvelocityx;
	public float _minvelocityy;
	public Vector3 direction;
	public GameObject particle;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col)
	{
        //print("tag name: " + col.gameObject.tag);

		if (col.gameObject.tag == "centerhex") 
		{
			GameManager.instance.updateScore (100);
            SoundManager.instance.PlaySingleByTag("centerhex");
		}
		if (col.gameObject.tag == "innerhex") 
		{
			GameManager.instance.updateScore (50);
            SoundManager.instance.PlaySingleByTag("innerhex");
        }
		if (col.gameObject.tag == "outerhex")
		{
			GameManager.instance.updateScore (25);
            SoundManager.instance.PlaySingleByTag("outerhex");
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "innerbump")
        {
			GameObject temp = Instantiate ((GameObject)particle, transform.position, particle.transform.rotation);
            SoundManager.instance.PlaySingleByTag("innerbump");
        }
        if (col.gameObject.tag == "outerbump")
        {
			GameObject temp = Instantiate ((GameObject)particle, transform.position, particle.transform.rotation);
            SoundManager.instance.PlaySingleByTag("outerbump");
        }
        if (col.gameObject.tag == "wall")
		{			
			GameObject temp = Instantiate ((GameObject)particle, transform.position, particle.transform.rotation);
            SoundManager.instance.PlaySingleByTag("wall");
        }
        if (col.gameObject.tag == "pulse")
        {
			GameObject temp = Instantiate ((GameObject)particle, transform.position, particle.transform.rotation);
            SoundManager.instance.PlaySingleByTag("pulse");
        }
    }

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.AddForce(Vector2.left * 1, ForceMode2D.Impulse);
    }
}
