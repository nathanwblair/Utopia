using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MammothDrop : MonoBehaviour {

    public Transform player;

    private GameObject mammoth;
    private List<GameObject> mammoths2D = new List<GameObject>();
    public int maxNumOf2D = 10;

    public int lengthOfAcc = 2;        //second for lerp
    public int fullAnimationLength = 5;    //time they run on the screen
    public int spawn2DXPosOffset = 10;
    public int spawn2DZPosOffset = 10;
    private float totalTimer;             //current point in animation 0-1
    //private int timer;

    private Vector3 leftMammothStartPos;
    private Vector3 rightMammothStartPos;
    private Vector3 leftMammothEndPos;
    private Vector3 rightMammothEndPos;

    // Use this for initialization
    void Start ()
    {
        //Get Mammoth Object
        mammoth = transform.GetChild(0).gameObject;
        
        GameObject tempObject = Instantiate(mammoth);
        //Creat 2D vertions
        for(int i=0; i < maxNumOf2D; i++)
        {
            int randY = Random.Range(0, Screen.width);
            int rand = Random.Range(0, 2);
            if (rand == 0)
            {
                tempObject.transform.position = new Vector3(-spawn2DXPosOffset, randY, Camera.main.transform.position.z + spawn2DZPosOffset);
                tempObject.transform.Rotate(new Vector3(0, 90, 0));
            }
            else if(rand == 1)
            {
                tempObject.transform.position = new Vector3(Screen.width + spawn2DXPosOffset, randY, Camera.main.transform.position.z + spawn2DZPosOffset);
                tempObject.transform.Rotate(new Vector3(0, -90, 0));
            }
            tempObject.transform.localScale = new Vector3(0.2f * spawn2DZPosOffset, 0.1f * spawn2DZPosOffset, 0.1f * spawn2DZPosOffset);

            mammoths2D.Add((GameObject)Instantiate(tempObject, Camera.main.ScreenToWorldPoint(tempObject.transform.position), Camera.main.transform.rotation).GetComponent<AnimationController>().Initialize());
        }
        Destroy(tempObject);
        
        //Set up lerp locations
        leftMammothEndPos = new Vector3(-3, 0, 5);
        rightMammothEndPos = new Vector3(-3, 0, -5);
        leftMammothStartPos = new Vector3(leftMammothEndPos.x - 5, leftMammothEndPos.y, leftMammothEndPos.z);
        rightMammothStartPos = new Vector3(rightMammothEndPos.x - 5, rightMammothEndPos.y, rightMammothEndPos.z);

        totalTimer = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = player.transform.position;
        totalTimer += Time.deltaTime;

        foreach(GameObject obj in mammoths2D)
        {
            //obj.GetComponent<Rigidbody>().;
        }

        //if (transform.position != leftMammothEndPos)



    }
}
