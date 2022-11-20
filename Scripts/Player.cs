using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float maxX;
    public float minX;

    public float speed;

    public bool travelingRight = true;

    public GameObject DeathParticle;

    public Rigidbody2D rb;

    private InputMaster controls;
     

    private flyingenemy enemy;

    private respawnPlayer respawn;
    public GameObject player;

    AudioSource source;
    public AudioClip bounceOffWall;
    public AudioClip swichDir;
    private SounEffecs efec;

    public bool hasPlayed = true;
    private void Awake()
    {
        controls = new InputMaster();
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
        
        controls.PlayerInput.Shoot.performed += _ => Shoot();
        efec = FindObjectOfType<SounEffecs>();
        source = GetComponent<AudioSource>();

        respawn = FindObjectOfType<respawnPlayer>();
        enemy = FindObjectOfType<flyingenemy>();
        rb = GetComponent<Rigidbody2D>();
        
    }
    private void FixedUpdate()
    {
        if (transform.position.x >= maxX)
        {
            travelingRight = false;

        }
        if (transform.position.x >= maxX && hasPlayed == false)
        {
            source.clip = bounceOffWall;
            source.Play();
            hasPlayed = true;
        }


        if (transform.position.x <= minX)
        {
            travelingRight = true;

        }
        if (transform.position.x <= minX && hasPlayed == false)
        {

            source.clip = bounceOffWall;
            source.Play();
            hasPlayed = true;
        }

        if (transform.position.x <= maxX && transform.position.x >= minX)
        {
            hasPlayed = false;
        }
        if (travelingRight)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
    }
    // Update is called once per frame

    private void Shoot()
    {
        if (travelingRight == true)
        {
            travelingRight = false;
            source.clip = swichDir;
            source.Play();
        }
        else if (travelingRight == false)
        {
            travelingRight = true;
            source.clip = swichDir;
            source.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            respawn.spawn.SetActive(false);
            respawn.powerup.SetActive(false);
            efec.Death();
            
            Instantiate(DeathParticle, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }

}
