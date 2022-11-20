using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    private float timeToSpawn;
    public float time = 5f;
    public GameObject powerUp;

    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = time + 1;
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn -= Time.deltaTime;
        if(timeToSpawn <= 0)
        {
            Instantiate(powerUp, transform.position, transform.rotation);
            timeToSpawn = time;
        }

    }
}
