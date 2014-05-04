using UnityEngine;
using System.Collections;

public class RandomShipBlue : MonoBehaviour
{
	public GameObject gameObject = null;

		// Use this for initialization
		void Start ()
		{

		for(int i = 1; i <=10; i++)
		{
			Vector3 position = new Vector3(Random.Range(-100,100), Random.Range(-100,100), Random.Range(-100,100));
			gameObject = Instantiate(Resources.Load("Explosion/ShipBlue"), position, Quaternion.identity) as GameObject;
		}


}
	
		// Update is called once per frame
		void Update ()
		{

		}
}

