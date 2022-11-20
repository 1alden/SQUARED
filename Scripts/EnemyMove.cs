using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
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

    public float respawnDelay;
    private Animator anim;
    private UIAnimator uiAnim;

    public float x;
    public float y;


    

    // Start is called before the first frame update
    void Start()
    {
       
        rotationSpeed = Random.Range(90f, 180f);
        transform.position = new Vector2(x, y);
        uiAnim = FindObjectOfType<UIAnimator>();
        anim = GetComponent<Animator>();
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
        if(col.tag == "Player")
        {
           
            uiAnim.GameOver();
            StartCoroutine("StartMenu");

            

            Instantiate(DeathParticle, transform.position, transform.rotation);
            
           
            
            
           
        }

        if(col.tag == "Boundry")
        {
            Instantiate(DeathParticle, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }
    public void DestroyEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < enemies.Length; i++)
        {
            
            Destroy(enemies[i]);
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

    public IEnumerator StartMenu()
    {

        DestroyPowerUp();
        DestroyEnemy();
        yield return new WaitForSeconds(respawnDelay);
        





    }



}
