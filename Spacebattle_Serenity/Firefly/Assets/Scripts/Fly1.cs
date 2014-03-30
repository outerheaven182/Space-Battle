using UnityEngine;
using System.Collections;

public class Fly1: MonoBehaviour
{
	//The purpose of this script is to simulate Newtonian phy
	public float maxThrust = 10; //The maximum Thrust provided by the thruster(s) at full throttle
	public float maxThrustforward = 10;
	public float rollWeight = 1; //This float and the next two only serve to adjust sensitivity
	public float pitchWeight = 1;//of the controls, and to allow calibration for more massive ships.
	public float yawWeight = 1;//Set these 3 floats to the mass of the rigidbody for sensitive control
	// Update is called once per frame
	
	void FixedUpdate ()
	{
		float yaw = yawWeight*Input.GetAxis("Yaw");
		float roll = rollWeight*Input.GetAxis("Roll");
		float pitch = pitchWeight*Input.GetAxis("Pitch");
		Vector3 Rotation = new Vector3(pitch, roll, yaw);
		rigidbody.AddRelativeTorque(Rotation);
		float throttle = maxThrust *Input.GetAxis("Thrust");
		rigidbody.AddRelativeForce(Vector3.down*throttle);
		float throttleforward = maxThrustforward *Input.GetAxis("Thrustforward");
		rigidbody.AddRelativeForce(Vector3.forward*throttleforward);
		System.Console.WriteLine("input is "+ yaw.ToString()+", "+pitch.ToString()+", "+roll.ToString());
	}
}