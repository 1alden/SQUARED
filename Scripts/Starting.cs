using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{
    private respawnPlayer respawn;

    private UIAnimator uianim;
    AudioSource source;
    public AudioClip button;
    // Start is called before the first frame update
    void Start()
    {
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
        uianim.Startstart();

        respawn.Respawn();


        StartCoroutine("RestartGame");


    }

    public IEnumerator RestartGame()
    {
        respawn.powerup.SetActive(false);
        respawn.spawn.SetActive(false);
        yield return new WaitForSeconds(3f);
        ScoreManager.instance.ResetScore();
        yield return new WaitForSeconds(3f);
        respawn.spawn.SetActive(true);
        respawn.powerup.SetActive(true);


    }
}
