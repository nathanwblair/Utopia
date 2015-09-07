using UnityEngine;
using Random = UnityEngine.Random;
using System;
using System.Collections;

public class MammothSmallAnimationController : AnimationController
{
    Vector3 start;
    Vector3 end;
    public float speed;
    bool isLeft;

    // Use this for initialization
    void Start () {
        isLeft = Convert.ToBoolean((int)(Random.Range(0, 2)));
	}

    // Update is called once per frame
    public override void Animate()
    {
        if (isLeft)
        {
            start = pointA + Camera.main.transform.position;
            end = pointB + Camera.main.transform.position;
        }
        else if (!isLeft)
        {
            start = pointB + Camera.main.transform.position;
            end = pointA + Camera.main.transform.position;
        }
        //Debug.Break();


        transform.position = Vector3.Lerp(start, end, (parentSpawner.timer / parentSpawner.dropLengthTime) * speed);
    }
}
