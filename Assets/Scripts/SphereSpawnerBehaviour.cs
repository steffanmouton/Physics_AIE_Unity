using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawnerBehaviour : MonoBehaviour
{
    private float time;
    public float interval = 1.0f;

    public Transform spawnLocation;

    public GameObject itemToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > interval)
        {
            time = 0.0f;

            Instantiate(itemToSpawn, spawnLocation);
        }
    }
}
