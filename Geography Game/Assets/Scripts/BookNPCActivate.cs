using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookNPCActivate : MonoBehaviour
{
    void Update()
    {
        if(StateNameController.townProgress == 20)
        {
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<CapsuleCollider>().enabled = true;
        }
    }
}
