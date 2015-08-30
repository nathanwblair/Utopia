using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour
{
	public AudioClip sound;

	public float lifespan = 1f;

	private float timeTillDeath = 0f;

	public int priority;

	private static SoundManager manager = null;

	// Use this for initialization
	void Start ()
	{
		if (manager == null)
		{
			manager = GameObject.Find("GameManager").GetComponent<SoundManager>();
		}
	}

	void Initialize(AudioClip _sound, float _lifeSpan, int _priority)
	{
		sound = _sound;
		lifespan = _lifeSpan;
		priority = _priority;
	}

	// Update is called once per frame
	void Update ()
	{
		timeTillDeath -= Time.deltaTime;

		if (timeTillDeath < 0f)
		{
			Destroy(gameObject);
		}

		if (manager.SetClip(sound, priority))
		{
			Destroy(gameObject);
		}
	}
}
