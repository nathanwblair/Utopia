using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
	int currentClipPriority = -1;

	public AudioSource musicTrack;
	public AudioSource soundTrack;

	// Use this for initialization
	void Start ()
	{
		soundTrack.volume = 0.5f;
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
