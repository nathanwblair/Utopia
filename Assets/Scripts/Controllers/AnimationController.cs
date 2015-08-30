using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

    public Vector3 pointA;
    public Vector3 pointB;

	// Use this for initialization
	void Start () 
    {
	     
	}

    void Update()
    { 
        
    }

    public void Initialise(Vector3 _pointA, Vector3 _pointB, Quaternion _rotation)
    {
        pointA = _pointA;
        pointB = _pointB;
        transform.rotation = _rotation;
    }

	// Update is called once per frame
	public virtual void Animate () 
    {
	    
	}
}
