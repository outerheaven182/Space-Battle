using UnityEngine;
using System.Collections;

public class CubeArrive : MonoBehaviour {

	/*private void CreatePath(int points, float radius)
	{
		
	}
	
	private void DrawPath()
	{
		Debug.DrawLine(transform.position, Vector3(Target) , Color(255,0,0));
	}*/


	public GameObject Target;
	public GameObject Target2;
	public float Speed = 10.0f;
	public float Move;
	bool Follow = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Move = Speed * Time.deltaTime;
	
		if(Follow == true)
		{
		transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Move);
		
			if(transform.position == Target.transform.position)
			{
				
				Delay();
				
			}
		
		}

		if(Follow == false)
		{
			transform.position = Vector3.MoveTowards(transform.position, Target2.transform.position, Move);

				if(transform.position == Target2.transform.position)
				{
					Restart();
				}
		}

	}

	void Delay()
		{
			Follow = false;
		}

	void Restart()
	{
		Follow = true;
	}
}


