using UnityEngine;
using System.Collections;

public class RandomEnemies : MonoBehaviour
{
	public GameObject gameObject = null;

		// Use this for initialization
		void Start ()
		{

		for(int i = 1; i <=30; i++)
		{
			Vector3 position = new Vector3(Random.Range(-400,400), Random.Range(-400,400), Random.Range(-400,400));
			gameObject = Instantiate(Resources.Load("Explosion/Cylinder"), position, Quaternion.identity) as GameObject;
		}
	}
	
		// Update is called once per frame
		void Update ()
		{

		}
}

