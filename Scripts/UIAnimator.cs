using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnimator : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        anim.SetTrigger("GameOver");
    }
    public void NewGame()
    {
        anim.SetTrigger("NewGame");
    }
    public void Startstart()
    {
        anim.SetTrigger("Start");
    }
}
