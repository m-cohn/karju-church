using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconBehavior : MonoBehaviour
{
    [SerializeField] private Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.LookAt(transform.position + cam.forward);
    }
}
