using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnPlayer : MonoBehaviour
{
    public bool hasSpawned;
    private Player player;
    public Transform pos;

    public GameObject spawn;
    public GameObject powerup;


    public GameObject playerPlayer;

    public bool sceneChanged = true;
    // Start is called before the first frame update
    void Start()
    {
        powerup.SetActive(false);
        spawn.SetActive(false);
        player = FindObjectOfType<Player>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Respawn() {

        StartCoroutine("RestartGame");
    }
    public IEnumerator RestartGame()
    {
        if(hasSpawned == false)
        {
            yield return new WaitForSeconds(1.2f);
            Instantiate(playerPlayer, pos.transform.position, transform.rotation);
            hasSpawned = true;
            yield return new WaitForSeconds(1.2f);
            hasSpawned = false;
        }
        
    }
}
