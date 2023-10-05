using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetermineLighting : MonoBehaviour
{
    public GameObject lighting;
    void Start()
    {
        if (StateNameController.townProgress == 40)
        {
            lighting.SetActive(true); 
        }
        if (StateNameController.townProgress == 100)
        {
            lighting.SetActive(true);
        }
    }
}
