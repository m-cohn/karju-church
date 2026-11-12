using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DetectClick : MonoBehaviour
{
    private GlobalVariables global = new GlobalVariables();

    [SerializeField] private GameObject cam;
    [SerializeField] private EnableUI canvasTwoD;
    [SerializeField] private EnableUI canvasThreeD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectRay();
    }

    private void DetectRay()
    {         
        if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), 
            20, LayerMask.GetMask("Clickable")))
        {
            canvasTwoD.Show(global.textIndex);
            canvasThreeD.Show(global.glassIndex);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E pressed");
                canvasTwoD.Show(global.testStoryIndex);
                canvasTwoD.Hide(global.textIndex);
                canvasThreeD.Hide(global.glassIndex);
            }
        }

        else
        {
            canvasTwoD.Hide(global.textIndex);
            canvasThreeD.Hide(global.glassIndex);
        }
    }
}
