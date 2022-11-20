using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    
    private respawnPlayer respawn;
   
    private UIAnimator uianim;

    AudioSource source;
    public AudioClip button;
    private flyingenemy enemy;
    public bool gameOver;
    public Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        
        enemy = FindObjectOfType<flyingenemy>();
        source = GetComponent<AudioSource>();
        uianim = FindObjectOfType<UIAnimator>();
        respawn = FindObjectOfType<respawnPlayer>();
        
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartingGamesd()
    {
        source.clip = button;
        source.Play();
        uianim.NewGame();

        respawn.Respawn();


        StartCoroutine("RestartGame");


    }

    public IEnumerator RestartGame()
    {

       
        yield return new WaitForSeconds(0.6f);
        ScoreManager.instance.ResetScore();
        yield return new WaitForSeconds(0.6f);
        respawn.spawn.SetActive(true);
        respawn.powerup.SetActive(true);
        yield return new WaitForSeconds(0.01f);
        gameOver = true;
        yield return new WaitForSeconds(0.01f);
        gameOver = false;


    }


}
