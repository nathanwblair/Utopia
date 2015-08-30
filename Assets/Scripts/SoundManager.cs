using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
	int currentClipPriority = -1;

	public AudioSource musicTrack;
	public AudioSource soundTrack;

	public AudioClip testClip;
	public AudioClip testClip2;

	// Use this for initialization
	void Start ()
	{
		soundTrack.volume = 0.5f;
		SetClip(testClip2, 0);
	}

	// Update is called once per frame
	void Update ()
	{
		if (!soundTrack.isPlaying)
		{
			currentClipPriority = -1;
		}
	}

	public bool SetClip(AudioClip source, int priority)
	{
		if (soundTrack.clip != null)
		{
			if (priority < currentClipPriority || currentClipPriority == -1)
			{
				soundTrack.Stop();
				soundTrack.clip = source;
				soundTrack.Play();
				currentClipPriority = priority;
				return true;
			}
		}
		else
		{
			soundTrack.clip = source;
			soundTrack.Play();
			currentClipPriority = priority;
			return true;
		}

		return false;
	}


}
