using UnityEngine;
using System.Collections;

public class MammothDrop : MonoBehaviour {

    public Transform player;

    private GameObject mammoth;
    private GameObject mammothUI;

    // Use this for initialization
    void Start () {
        mammoth = transform.GetChild(0).gameObject;
        mammothUI = mammoth;
        mammothUI.transform.Rotate(new Vector3(90, 0, 0));
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position;
	}
}
