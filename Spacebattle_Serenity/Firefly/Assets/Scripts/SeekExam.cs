using UnityEngine;
using System.Collections;

public class SeekExam : MonoBehaviour {
	
	public float Distance;
	public Transform Target;
	public float lookAtDistance= 15.0f;
	public float chaseRange= 10.0f;
	public float moveSpeed= 5.0f;
	
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
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); 
	}
}