﻿using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public float Distance;
	public Transform Target;
	public float lookAtDistance= 125.0f;
	public float chaseRange= 100.0f;
	public float moveSpeed= 1.0f;
	
	/*
  This ai will fly and move through objects inlcuding terrain!
*/
	void  Update (){
		
		// Gauge the distance to the player. Line in 3d space. Draws a line from source to Target.
		Distance = Vector3.Distance(Target.position, transform.position);
		
		// AI begins tracking player.
		if (Distance < lookAtDistance)
		{
			lookAt();
		}
		
		// Attack! Chase the player until/if player leaves attack range.
		if (Distance < chaseRange)
		{if(Distance <10)
			{
				lookAt();
			}
			else
			{
				Debug.Log("enemy chase");
				chase ();
			}
		}
	}
	
	// Turn to face the player.
	void  lookAt (){
		// Rotate to look at player.
		Quaternion rotation= Quaternion.LookRotation(Target.position - transform.position);
		
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
		//transform.LookAt(Target); alternate way to track player replaces both lines above.
	}
	
	void  chase (){
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); 
	}
}