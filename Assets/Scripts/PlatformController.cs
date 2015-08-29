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
				GameObject item = Instantiate(items[i]);
				item.transform.parent = GameObject.Find("Items").transform;
				item.transform.position = transform.GetChild(i).position;
			}
		}
	}

	// Update is called once per frame
	void Update ()
	{

	}
}
