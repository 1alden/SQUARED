using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    public bool pointsAdded = false;

    AudioSource source;
    public AudioClip point;
    private SounEffecs efec;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        efec = FindObjectOfType<SounEffecs>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && pointsAdded == false) {
            
            ScoreManager.instance.addScore();
            pointsAdded = true;
            efec.Point();
        }
       
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        StartCoroutine("wIT");
    }
    public IEnumerator wIT()
    {

        yield return new WaitForSeconds(1f);
        pointsAdded = false;
    }
}
