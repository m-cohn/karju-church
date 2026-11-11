using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableUI : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objects;
    private bool visible;

    public bool Visible
    {
        get { return visible; }
    }

    public void Show()
    {
        foreach (GameObject item in objects)
        {
            item.SetActive(true);
        }

        visible = true;
    }

    public void Hide()
    {
        foreach (GameObject item in objects)
        {
            item.SetActive(false);
        }

        visible = false;
    }
}
