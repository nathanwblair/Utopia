using UnityEngine;
using System.Collections;

public class SpawnerController : MonoBehaviour {

	// Use this for initialization
    public GameObject prefab;
    public int instanceCount = 4;

    void Start()
    {
        for (int i = 0; i < instanceCount; i++)
        {
            GameObject instance = Instantiate(prefab);
            InstastiateDrop(instance);
        }
    }

    public virtual void InstastiateDrop(GameObject _instance)
    { 
        // Do Nothing...
    }
}
