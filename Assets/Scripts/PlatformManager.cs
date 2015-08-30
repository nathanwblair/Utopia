using UnityEngine;
using System.Collections;

public class PlatformManager : MonoBehaviour
{
	public int numPlatforms = 10;
	public GameObject[] platformTypes = null;
	public GameObject startPlatform = null;
	public GameObject endPlatform = null;

	// Use this for initialization
	void Start ()
	{
		if (platformTypes != null)
		{
			GameObject prevPlatform = Instantiate(startPlatform);

			for (int i = 1; i < numPlatforms - 1; i++)
			{
				GameObject platform = Instantiate(platformTypes[Random.Range(0, platformTypes.Length)]);
				platform.transform.parent = prevPlatform.transform;

				platform.transform.position = platform.transform.parent.FindChild("EndMarker").position;
				prevPlatform = platform;
			}

			endPlatform = Instantiate(endPlatform);
			endPlatform.transform.parent = prevPlatform.transform;

			endPlatform.transform.position = endPlatform.transform.parent.FindChild("EndMarker").position;
		}

	}

	// Update is called once per frame
	void Update ()
	{

	}
}
