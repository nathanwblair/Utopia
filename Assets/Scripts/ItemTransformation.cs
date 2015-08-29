// Animates the item to highlight its a collectable. 

using UnityEngine;
using System.Collections;

public class ItemTransformation : MonoBehaviour {

    public float bobTime; 
    public float speed;
    public Rigidbody rb;

	// Use this for initialization
	void Start () 
    {
        speed = 1.0f;
        bobTime = 6.0f;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {
       transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);

       transform.position += new Vector3(0, Mathf.Sin(bobTime) * speed * Time.deltaTime, 0);
       bobTime += Time.deltaTime;
    
	}
}
