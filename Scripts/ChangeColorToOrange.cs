using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorToOrange : MonoBehaviour
{
    private EnemyMove enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy = FindObjectOfType<EnemyMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            
        }

    }
}
