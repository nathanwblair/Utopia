using UnityEngine;
using System.Collections;

public class SpawnerController : MonoBehaviour {

	// Use this for initialization
    public GameObject prefab;
    public int instanceCount = 4;
    public float dropLengthTime;
    public float timer;

    void Start()
    {
        timer = 0;
        Initialise();
        for (int i = 0; i < instanceCount; i++)
        {
            GameObject instance = Instantiate(prefab);
            instance.transform.parent = transform;
            InitialiseDrop(instance);
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= dropLengthTime)
        {
            Destroy(gameObject);
        }
    }

    public virtual void InitialiseDrop(GameObject _instance)
    { 
        // Do Nothing...
    }

    public virtual void Initialise()
    {
        // Do Nothing...
    }
}
