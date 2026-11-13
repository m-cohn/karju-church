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

    public IEnumerator FadeIn(int i)
    {
        GameObject child = objects[i].transform.GetChild(0).gameObject;
        Color c = child.GetComponent<Renderer>().material.color;

        for (float alpha = 0f; alpha <= 1f; alpha += 0.1f)
        {
            c.a = alpha;
            child.GetComponent<Renderer>().material.color = c;

            yield return new WaitForSeconds(.1f);
        }
    }

    /* public void Show(int i, bool slow)
     {
         Show(i);
         SlowShow(i);
     }

     IEnumerator SlowShow(int i)
     {
         GameObject child = objects[i].transform.GetChild(0).gameObject;
         Color c = child.GetComponent<Renderer>().material.color;

         for (float alpha = 0f; alpha <= 1f; alpha += 0.1f)
         {
             Debug.Log(alpha);
             c.a = alpha;
             child.GetComponent<Renderer>().material.color = c;
             yield return null;
         }
     }

     public void SlowHide(int i)
     {
         Hide(i);

         GameObject child = objects[i].transform.GetChild(0).gameObject;
         Color c = child.GetComponent<Renderer>().material.color;

         for (float alpha = 0f; alpha <= 1f; alpha += 0.1f)
         {
             c.a = alpha;
             child.GetComponent<Renderer>().material.color = c;
         }
     }*/

    public bool objectVisibility(int i)
    {
        return objects[i].activeSelf;
    }
}
