using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public float RotationSpeed = 1f;
	
	void Update () 
	{
		transform.RotateAround(transform.up, RotationSpeed * Time.deltaTime);
	}
}
