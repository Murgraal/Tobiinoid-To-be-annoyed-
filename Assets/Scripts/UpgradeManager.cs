using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour 
{
	public static UpgradeManager instance;
	public float Timer;
	public Vector3 original;

	void Awake()
	{
		if (instance == null)
			instance = this;
		if (instance != this)
			Destroy (gameObject);
	}

	void Start () 
	{
		original = GameManager.instance.Paddle.transform.localScale;
	}
	void Update ()
	{
		switch (GameManager.instance.upgrades) 
		{
		case Upgrades.none:
			none (GameManager.instance.Paddle);
			break;
		case Upgrades.mini:
			mini (GameManager.instance.Paddle);
			break;
		case Upgrades.mega:
			mega (GameManager.instance.Paddle);
			break;
		case Upgrades.dubbel:
			dubbel(GameManager.instance.innerpaddle);
			break;
		case Upgrades.speed:
			speed (InputManager.Instance._speed);
			break;
		}
	}
		

	void none(GameObject player)
	{
		GameManager.instance.innerpaddle.SetActive(false);
		InputManager.Instance._speed = 200;
		player.transform.localScale = original;
	}

	void mini(GameObject player)
	{
			player.transform.localScale = new Vector3 (2f
			, player.transform.localScale.y
				, player.transform.localScale.z);
		
	}
	void mega(GameObject player)
	{
		player.transform.localScale = new Vector3 (5f
			, player.transform.localScale.y
				, player.transform.localScale.z);

	}
	void dubbel(GameObject player)
	{
	player.SetActive(true);	
	}
	void speed(float speed)
	{
	speed = 300;
	}
	public void addballs(GameObject ball)
	{
	Instantiate ((GameObject)ball, Vector2.zero, Quaternion.identity);
	}
	public void removeball(GameObject ball)
	{
		if (ball != null) 
		{
			Destroy (ball);
		}
	}
	// Update is called once per frame

}
