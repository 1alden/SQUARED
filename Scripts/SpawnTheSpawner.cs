using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTheSpawner : MonoBehaviour
{
    public GameObject rightEnemy;
    public GameObject leftEnemy;
    public GameObject centerEnemy;

    public Transform rightSpawn;
    public Transform leftSpawn;
    public Transform centerSpawn;



    public float waitTimeBetweenShots;
    private float shotCounter;
    public Transform spawnPoint;

    GameObject[] enemys = new GameObject[3];



    void Start()
    {
        enemys[0] = Instantiate(rightEnemy, rightSpawn.transform.position, transform.rotation);
        enemys[1] = Instantiate(leftEnemy, leftSpawn.transform.position, transform.rotation);
        enemys[2] = Instantiate(centerEnemy, centerSpawn.transform.position, transform.rotation);


    }

    // Update is called once per frame
    void Update()
    {

        shotCounter -= Time.deltaTime;
        if (shotCounter < 0)
        {


            Random.Range(0, enemys.Length);
            shotCounter = waitTimeBetweenShots;
        }
        
        

    }
    
}
