using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	public GameObject following;
	Vector3 offset;

	// Use this for initialization
	void Start ()
	{
		offset = following.transform.position - transform.position;
	}


	// Update is called once per frame
	void Update ()
	{
		transform.position = following.transform.position - offset;
	}
}
