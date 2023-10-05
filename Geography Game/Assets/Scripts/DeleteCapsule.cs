using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCapsule : MonoBehaviour
{
    public void DeleteCollider()
    {
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
    }
    public void EnableCollider()
    {
        gameObject.GetComponent<CapsuleCollider>().enabled = true;
    }
    public void EnableVisibility()
    {
        gameObject.SetActive(true);
    }
    public void DisableVisibility()
    {
        gameObject.SetActive(false);
    }
}
