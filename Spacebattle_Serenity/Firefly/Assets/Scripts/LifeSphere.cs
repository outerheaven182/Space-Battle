using UnityEngine;

public class LifeSphere : MonoBehaviour
{
	public GameObject Player;

	void OnTriggerEnter(Collider theEnterer )
	{
		if( theEnterer.tag == "Player")
		{
			Player.light.intensity = 1;;
  		}
		Destroy (gameObject);
	}
}