using UnityEngine;
using System.Collections;


public class CircleFollowing : MonoBehaviour {

	/*private void CreatePath(int points, float radius)
	{
		
	}
	
	private void DrawPath()
	{
		Debug.DrawLine(transform.position, Vector3(Target) , Color(255,0,0));
	}*/


	public float mass = 1.0f;
	public float Distance;
	public Transform Target;
	public float lookAtDistance= 10.0f;
	public float chaseRange= 1.0f;
	public float maxSpeed= 5.0f;


	
	void  Update (){
		
		Distance = Vector3.Distance(Target.position, transform.position);
		
		if (Distance < lookAtDistance)
		{
			lookAt();
		}
		
		if (Distance < chaseRange)
		{if(Distance <3)
			{
				lookAt();
			}
			else
			{
				Debug.Log("Seek");
				chase ();
			}
		}
	}
	
	void  lookAt ()
	{
		Quaternion rotation= Quaternion.LookRotation(Target.position - transform.position);
		
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
	}
	
	void  chase (){
		transform.Translate(Vector3.forward * maxSpeed * Time.deltaTime); 
	}
}