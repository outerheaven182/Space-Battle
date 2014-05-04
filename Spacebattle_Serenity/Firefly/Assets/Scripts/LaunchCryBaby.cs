using UnityEngine;
using System.Collections;

public class LaunchCryBaby : MonoBehaviour {

	public GameObject CryBaby;
	public GameObject Chaser;
	public GameObject Chaser2;
	public GameObject Chaser3;
	public float force = -0.1f;
	bool Crying = false;
	//bool Destroyed = true;
	void Start ()
	{
		/*/Destroyed = true;
		Chaser.GetComponent<SeekExam>().enabled = true;
		Chaser.GetComponent<FollowDecoy>().enabled = false;*/
	}
	// Update is called once per frame
	void Update () 
	{
	if(Crying == false)
	{
			//Destroyed = true;
			Chaser.GetComponent<FollowDecoy>().enabled = false;
			Chaser.GetComponent<SeekExam>().enabled = true;

			Chaser2.GetComponent<FollowDecoy>().enabled = false;
			Chaser2.GetComponent<SeekExam>().enabled = true;

			Chaser3.GetComponent<FollowDecoy>().enabled = false;
			Chaser3.GetComponent<SeekExam>().enabled = true;
	}
		if(Input.GetButton("Jump"))
		{
			GameObject pro = Instantiate(CryBaby, transform.position, Quaternion.identity)as GameObject;

			Crying = true;

			Chaser.GetComponent<SeekExam>().enabled = false;
			Chaser.GetComponent<FollowDecoy>().enabled = true;

			Chaser2.GetComponent<SeekExam>().enabled = false;
			Chaser2.GetComponent<FollowDecoy>().enabled = true;

			Chaser3.GetComponent<SeekExam>().enabled = false;
			Chaser3.GetComponent<FollowDecoy>().enabled = true;

			
			//Destroyed = false;
			//pro.AddComponent<Rigidbody>();
			//pro.rigidbody.velocity = transform.forward * force;
			//force = -0.001f;
		

		}
		if(CryBaby.transform.position.y <= -100 == true)
		{

			Crying = false;
			Chaser.GetComponent<FollowDecoy>().enabled = false;
			Chaser.GetComponent<SeekExam>().enabled = true;
			Destroy(CryBaby, 3);
			
		}
		/*if(Crying == true)
		{
			//Destroyed = true;
			Chaser.GetComponent<SeekExam>().enabled = false;
			Chaser.GetComponent<FollowDecoy>().enabled = true;
		}*/
			
	}
		/*void DestroyedObject()
		{
			Chaser.GetComponent<SeekExam>().enabled = true;
			Chaser.GetComponent<FollowDecoy>().enabled = false;
			Crying = false;
		}*/
}
