using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingenemy : MonoBehaviour
{
    /// <summary>
    /// ////////////////////////////////////////
    /// </summary>
    

    private float numberToSpawn;
    public float number = 1f;

    [SerializeField]
    private GameObject[] enemies;

    private int randomPrefab;

    public float decreaseTime;

    public float minTime = 0.65f;

    private PlayButton button;

    public void Start()
    {
        number = 2;
        button = FindObjectOfType<PlayButton>();
        numberToSpawn = number + 2;

    }

    void Update()
    {
        if(button.gameOver == true)
        {
            number = 2;
        }

        if (numberToSpawn <= 0)
        {
            randomPrefab = Random.Range(0, 3);
            Instantiate(enemies[randomPrefab], transform.position, transform.rotation);
            numberToSpawn = number;
            
           
        } else
        {
            numberToSpawn -= Time.deltaTime;
        }
    }
    public void decreaseTimed()
    {
        if (number > minTime)
        {
            number -= decreaseTime;
        }
            
    }
    


}
