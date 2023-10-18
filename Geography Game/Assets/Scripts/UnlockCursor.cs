using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCursor : MonoBehaviour
{
    public void unlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void lockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
