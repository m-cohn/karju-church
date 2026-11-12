using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorSettings : MonoBehaviour
{
    public static void Looking()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public static void Selecting()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
