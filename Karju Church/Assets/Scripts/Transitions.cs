using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FadeIn()
    {
        Color c = GetComponent<Renderer>().material.color;

        for (float alpha = 0f; alpha <= 1f; alpha += 0.1f)
        {
            c.a = alpha;
            GetComponent<Renderer>().material.color = c;
        }
    }

    public void FadeOut()
    {

    }
}
