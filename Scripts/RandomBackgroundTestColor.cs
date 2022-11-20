using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBackgroundTestColor : MonoBehaviour
{
    Color[] colors = new Color[2];

    void Start()
    {
        colors[0] = new Color(255, 255, 255);
        colors[1] = new Color(48, 19, 86);

        GetComponent<Renderer>().material.color = colors[(0)];
    }

    void Dark()
    {
        GetComponent<Renderer>().material.color = colors[(1)];
    }

        
    
}
