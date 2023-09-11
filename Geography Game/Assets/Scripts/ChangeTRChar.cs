using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTRChar : MonoBehaviour
{
    public Transform targetPlayer;
    public Transform originalPos;
    public Quaternion originalRot;

    public void Start()
    {
        originalPos = gameObject.transform;
        originalRot = gameObject.transform.rotation;
    }
    public void changeRotation()
    {
        gameObject.transform.LookAt(targetPlayer);
    }
    public void originalRotation()
    {
        gameObject.transform.rotation = originalRot;
    }
}
