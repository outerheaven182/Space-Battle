using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]

public class VideoCryBaby : MonoBehaviour
{
	public MovieTexture movie;

	void Start()
		{
			renderer.material.mainTexture = movie as MovieTexture;
			audio.clip = movie.audioClip;
			movie.Play();
			audio.Play();
		}

	void Update()
	{
		if(!movie.isPlaying)
		{
			Destroy(gameObject);
		}
	}
}

