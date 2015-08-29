using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    private GameObject currentPlatform;

    // Use this for initialization
    void Start()
    {

    }

    // FixedUpdate is called before physics
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

<<<<<<< HEAD
		Vector3 movement = new Vector3(moveVertical, 0.0f, -moveHorizontal);
=======
        Vector3 movement = new Vector3(moveVertical, 0.0f, -moveHorizontal);
>>>>>>> origin/Stefan_Item_Text

        if (rb.velocity.x < 0f)
        {
            movement.x = 0f;
            rb.velocity = new Vector3(0f, rb.velocity.y, rb.velocity.z);
        }

        rb.AddForce(movement * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
