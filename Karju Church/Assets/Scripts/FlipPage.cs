using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipPage : MonoBehaviour
{
    private int children;
    private int activeChild;
    private GameObject curr;
    private int originalNum;

    [SerializeField] private GameObject mainObject;
    [SerializeField] private bool skipFirst;
    [SerializeField] private GameObject deactivateAfter;

    void Start()
    {
        children = mainObject.transform.childCount;

        if (skipFirst)
        {
            activeChild = 0;
        }

        else
        {
            activeChild = -1;
        }

        originalNum = activeChild + 1;

        curr = mainObject.transform.GetChild(originalNum).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.RightArrow))))
        {
            if (activeChild != children - 1)
            {
                curr.SetActive(false);

                activeChild += 1;

                curr = mainObject.transform.GetChild(activeChild).gameObject;

                curr.SetActive(true);
            }
            else
            {
                if (deactivateAfter.activeSelf)
                {
                    mainObject.SetActive(false);
                }
            }
        }

        else if ((Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.LeftArrow))) && activeChild != originalNum)
        {
            curr.SetActive(false);

            activeChild -= 1;
            curr = mainObject.transform.GetChild(activeChild).gameObject;

            curr.SetActive(true);
        }
    }
}
