using UnityEngine;
using System.Collections;

public class RandomExplosion : MonoBehaviour
{
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
			Vector3 position = new Vector3(Random.Range(-200,200), Random.Range(-200,200), Random.Range(-200,200));
			gameObject = Instantiate(Resources.Load("Explosion/Explosion"), position, Quaternion.identity) as GameObject;
		}

	}
}

