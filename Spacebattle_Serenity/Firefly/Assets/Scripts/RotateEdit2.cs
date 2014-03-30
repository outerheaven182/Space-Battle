using UnityEngine;
using System.Collections;

public class RotateEdit2 : MonoBehaviour {

	public float RotationSpeed = 1f;
	
	void Update () 
	{
		transform.RotateAround(transform.right, RotationSpeed * Time.deltaTime);
	}
}
