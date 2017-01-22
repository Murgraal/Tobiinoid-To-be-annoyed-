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
		if (Input.GetKeyDown (KeyCode.A))
			SetDuration (5);

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

	void SetDuration(float duration)
	{
		Timer = duration;
	}

	void none(GameObject player)
	{
		GameManager.instance.innerpaddle.SetActive(false);
		InputManager.Instance._speed = 200;
		player.transform.localScale = original;
	}

	void mini(GameObject player)
	{
		Timer -= Time.deltaTime;
		if (Timer > 0) {
			player.transform.localScale = new Vector3 (2f
			, player.transform.localScale.y
				, player.transform.localScale.z);
		}else
		{
			GameManager.instance.upgrades = Upgrades.none;
		}
	}
	void mega(GameObject player)
	{
		Timer -= Time.deltaTime;
		if (Timer > 0) {
			player.transform.localScale = new Vector3 (5f
			, player.transform.localScale.y
				, player.transform.localScale.z);
		} else
		{
			GameManager.instance.upgrades = Upgrades.none;
		}
	}
	void dubbel(GameObject player)
	{
		Timer -= Time.deltaTime;
		if (Timer > 0) {
			player.SetActive(true);
		} else
		{
			GameManager.instance.upgrades = Upgrades.none;
		}
	}
	void speed(float speed)
	{
		Timer -= Time.deltaTime;
		if (Timer > 0) {
			speed = 300;
		} else 
		{
			GameManager.instance.upgrades = Upgrades.none;
		}	
	}
	void addballs(GameObject ball)
	{
		Instantiate ((GameObject)ball, Vector2.zero, Quaternion.identity);
	}
	// Update is called once per frame

}
