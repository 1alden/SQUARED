using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMove : MonoBehaviour
{
    public float rotationSpeed;
    public float speedX;

    public float speedY;
    private Rigidbody2D rb;
    public GameObject DeathParticle;

    public float minSpeed = 1;
    public float maxSpeed = 3;
    private SpriteRenderer rend;

    private respawnPlayer respawn;


    // Start is called before the first frame update
    void Start()
    {
        respawn = FindObjectOfType<respawnPlayer>();
        rend = GetComponent<SpriteRenderer>();
        speedX = Random.Range(minSpeed, maxSpeed);
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.angularVelocity = rotationSpeed;
        rb.velocity = new Vector3(speedX, speedY);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            
            Instantiate(DeathParticle, transform.position, transform.rotation);
            Destroy(gameObject);
            
           
        }

        if (col.tag == "Boundry")
        {
            Instantiate(DeathParticle, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }

    public void DestroyPowerUp()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("PowerUp");
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }
}
