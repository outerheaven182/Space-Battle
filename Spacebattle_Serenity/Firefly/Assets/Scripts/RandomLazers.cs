using UnityEngine;
using System.Collections;

public class RandomLazers : MonoBehaviour
{
	public AudioClip blaster;

	public GameObject gameObject = null;

		// Use this for initialization
		void Start ()
		{

		}
	
		// Update is called once per frame
		void Update ()
		{

		for(int i = 1; i <=1; i++)
		{
			Vector3 position = new Vector3(Random.Range(-400,400), Random.Range(-400,400), Random.Range(-400,400));
			gameObject = Instantiate(Resources.Load("Explosion/LazerBlaster"), position, Random.rotation) as GameObject;
			//AudioSource.PlayClipAtPoint(blaster, transform.position);
		}
	}
}

