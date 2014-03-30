using UnityEngine;
using System.Collections;

public class fly : MonoBehaviour {

		public int flyingSpeed = 100;
		public int speedChange = 20;
		
		public int rotateInt = 2;
		
		void Update()
		{
			
			if (Input.GetKeyDown (KeyCode.W))
			{
				flyingSpeed += speedChange;
			}
			
			if (Input.GetKeyDown (KeyCode.S))
			{
				flyingSpeed += -speedChange;
			}
			
			if (Input.GetKey (KeyCode.A))
			{
				transform.RotateAround (transform.position, transform.up, -rotateInt);
			}
			
			if (Input.GetKey (KeyCode.D))
			{
				transform.RotateAround (transform.position, transform.up, rotateInt);
			}
		}

		void FixedUpdate() {
			
			transform.position += transform.forward * flyingSpeed * Time.deltaTime;
			
		}
	
	}
