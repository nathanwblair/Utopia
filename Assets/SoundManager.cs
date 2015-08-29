using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
	AudioSource soundClip = null;
	AudioSource soundTrack;

	int currentClipPriority = 0;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void SetClip(AudioSource source, int priority)
	{
		if (soundClip != null)
		{
			if (priority < currentClipPriority)
			{
				soundClip.Stop();
				soundClip = source;
				soundClip.Play();
				currentClipPriority = priority;
			}
		}
		else
		{
			soundClip = source;
			soundClip.Play();
			currentClipPriority = priority;
		}
	}


}
