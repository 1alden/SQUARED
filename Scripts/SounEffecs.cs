using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SounEffecs : MonoBehaviour
{
    AudioSource source;
    public AudioClip point;
    public AudioClip DeathClip;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Death()
    {
        source.clip = DeathClip;
        source.Play();
    }
    public void Point()
    {
        
        source.clip = point;
        source.Play();
        
    }
}
