// Animates the item to highlight its a collectable. 

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemTransformation : MonoBehaviour {

    public float bobTime; 
    public float speed;
    public string name;

    public GameObject drop;
 
    public GameObject textObject;

	// Use this for initialization
	void Start () 
    {
        speed = 1.0f;
        bobTime = 6.0f;
        textObject = Instantiate(textObject);
        textObject.transform.parent = transform;
        textObject.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        textObject.GetComponent<TextMesh>().text = name;
	}
	
	// Update is called once per frame
	void Update () 
    {
        //Debug.Break();
       transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);

       transform.position += new Vector3(0, Mathf.Sin(bobTime) * speed * Time.deltaTime, 0);
       bobTime += Time.deltaTime;
	}

    void OnCollisionEnter(Collision hit)
    {

        if(hit.gameObject.tag == "Player")
        {
          
            Instantiate(drop, transform.position, Quaternion.identity);
			Destroy(gameObject);
        }

    }
}
