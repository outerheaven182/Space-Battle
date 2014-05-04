using UnityEngine;
using System.Collections;

public class TestLight : MonoBehaviour {
	public float duration = 1.0F;
	void Update() {


		if(light.intensity <= 0.001)
		{
			Application.LoadLevel("WhatLiesBeneathGameTest");
		}
		else
		{
			float phi = Time.time / duration * 2 * Mathf.PI;
			float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
			light.intensity = amplitude;
		}
	}
}