using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
	public float despawntimer;
	public AnimationClip clip;

	// Use this for initialization
	void Start ()
    {
		despawntimer = clip.length;
	}

    // Update is called once per frame
    void Update()
    {
		despawntimer -= Time.deltaTime;
		if (despawntimer < 0)
			Destroy (gameObject);
    }
}