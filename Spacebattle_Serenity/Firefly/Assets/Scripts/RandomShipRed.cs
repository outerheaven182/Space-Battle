using UnityEngine;
using System.Collections;

public class RandomShipRed : MonoBehaviour
{
	public GameObject gameObject = null;

		// Use this for initialization
		void Start ()
		{

		for(int i = 1; i <=10; i++)
		{
			Vector3 position = new Vector3(Random.Range(-200,200), Random.Range(-200,200), Random.Range(-200,200));
			gameObject = Instantiate(Resources.Load("Explosion/ShipRed"), position, Quaternion.identity) as GameObject;
		}


}
	
		// Update is called once per frame
		void Update ()
		{

		}
}

