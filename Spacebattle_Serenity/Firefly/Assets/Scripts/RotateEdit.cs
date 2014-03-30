using UnityEngine;
using System.Collections;

public class RotateEdit : MonoBehaviour {

	public float RotationSpeed = 1f;
	
	void Update () 
	{
		transform.RotateAround(transform.forward, RotationSpeed * Time.deltaTime);
	}
}
