using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MammothSpawnerController : SpawnerController
{

    public Transform player;

    public GameObject mammothCustom;

    public int lengthOfAcc = 2;        //second for lerp
    public int fullAnimationLength = 5;    //time they run on the screen
    public int spawn2DXPosOffset = 10;
    public int spawn2DZPosOffset = 10;

    private Vector3 leftMammothStartPos;
    private Vector3 rightMammothStartPos;
    private Vector3 leftMammothEndPos;
    private Vector3 rightMammothEndPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void InitialiseDrop(GameObject instance)
    {
        //Creat 2D
        int randY = Random.Range(0, Screen.width);
        Vector3 posA = new Vector3(-spawn2DXPosOffset, randY, 0);
        Vector3 posB = new Vector3(Screen.width + spawn2DXPosOffset, randY, 0);

        instance.GetComponent<AnimationController>().Initialise(posA, posB, Camera.main.transform.rotation);
    }

    public override void Initialise()
    {
        //Set up lerp locations
        leftMammothEndPos = new Vector3(-3, 0, 5);
        rightMammothEndPos = new Vector3(-3, 0, -5);
        leftMammothStartPos = new Vector3(leftMammothEndPos.x - 5, leftMammothEndPos.y, leftMammothEndPos.z);
        rightMammothStartPos = new Vector3(rightMammothEndPos.x - 5, rightMammothEndPos.y, rightMammothEndPos.z);
    }
}
