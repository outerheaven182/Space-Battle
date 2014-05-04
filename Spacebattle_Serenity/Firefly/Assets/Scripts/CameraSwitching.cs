using UnityEngine;
using System.Collections;

public class CameraSwitching : MonoBehaviour 
{
	public Camera Camera1;
	public Camera Camera2;
	public Camera Camera3;
	public Camera Camera4;


	void Start()
	{
		Camera1.enabled = false;
		Camera2.enabled = true;
		Camera3.enabled = false;
		Camera4.enabled = false;
	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{		
			Camera1.enabled = false;
			Camera2.enabled = true;
			Camera3.enabled = false;
			Camera4.enabled = false;
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			Camera1.enabled = true;
			Camera2.enabled = false;
			Camera3.enabled = false;
			Camera4.enabled = false;
		}

		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			Camera1.enabled = false;
			Camera2.enabled = false;
			Camera3.enabled = true;
			Camera4.enabled = false;
		}

		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			Camera1.enabled = false;
			Camera2.enabled = false;
			Camera3.enabled = false;
			Camera4.enabled = true;
		}
	}

}
