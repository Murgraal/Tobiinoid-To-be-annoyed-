using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour 
{

	public static InputManager Instance;
	public float _speed;
	public GameObject _core,_core2;
	public enum Direction{right,left};
	public Direction direction;
	public Vector2 _direction;
	public float _angle;
	// Use this for initialization

	void Awake()
	{
		if (Instance == null)
			Instance = this;

		if (Instance != this)
			Destroy (gameObject);
	}

	void Start () 
	{
		_core = GameObject.Find ("Core");
		_core2 = GameObject.Find ("Core2");
	}

	void Update () 
	{
		//_direction = _core.transform.position - new Vector3
		print (_angle);
		if (Input.GetAxis("Horizontal") < -0.5)
			_core.transform.eulerAngles += new Vector3 (0, 0, _speed) * Time.deltaTime; ; 
		if (Input.GetAxis("Horizontal") > 0.5)
			_core.transform.eulerAngles -= new Vector3 (0, 0, _speed) * Time.deltaTime;;
		if (Input.GetAxis("horizontal") < -0.5)
			_core2.transform.eulerAngles += new Vector3 (0, 0, _speed) * Time.deltaTime; 
		if (Input.GetAxis("horizontal") > 0.5)
			_core2.transform.eulerAngles -= new Vector3 (0, 0, _speed) * Time.deltaTime;

			
		/*	direction = Direction.left;
		if (Input.GetKey (KeyCode.A) && direction == Direction.left) 
		{
			_core.transform.eulerAngles += new Vector3 (0, 0, _speed) * Time.deltaTime; 
		}
		if (Input.GetKeyDown (KeyCode.D))
			direction = Direction.right;
		if (Input.GetKey (KeyCode.D) && direction == Direction.right) 
		{
			_core.transform.eulerAngles -= new Vector3 (0, 0, _speed) * Time.deltaTime;
		} */
	}
}
