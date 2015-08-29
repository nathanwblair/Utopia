using UnityEngine;
using System.Collections;

public class PlatformController : MonoBehaviour
{
	public GameObject[] items = null;

	// Use this for initialization
	void Start ()
	{
		if (items != null)
		{
			for (int i = 0; i < items.Length; i++)
			{
				Instantiate(items[i], transform.GetChild(i).position, Quaternion.identity);
			}
		}
	}

	// Update is called once per frame
	void Update ()
	{

	}
}
