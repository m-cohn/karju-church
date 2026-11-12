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

    public void Show(int i)
    {
        objects[i].SetActive(true);

        visible = true;

        CursorSettings.Selecting();
    }

    public void Hide(int i)
    {
        objects[i].SetActive(false);

        visible = false;

        CursorSettings.Looking();
    }

    public bool objectVisibility(int i)
    {
        return objects[i].activeSelf;
    }
}
