using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]

public class VideoEnding : MonoBehaviour
{
	public MovieTexture movie;

	void Start()
		{
			renderer.material.mainTexture = movie as MovieTexture;
			audio.clip = movie.audioClip;
			movie.Play();
			audio.Play();
		}

	void OnMouseDown()
	{
		movie.Stop();
		Application.LoadLevel("Start");
	}

	void Update()
	{
		if(!movie.isPlaying)
		{
			Application.LoadLevel("Start");
		}
	}
}

