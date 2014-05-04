using UnityEngine;
using System.Collections;

public class Moveto : MonoBehaviour {

	public GameObject Target;
	public float Speed = 5.0f;
	public float Move;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Move = Speed * Time.deltaTime;

		if(Input.GetKey(KeyCode.Return))
		{
			transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Move);
		}
	}
}
