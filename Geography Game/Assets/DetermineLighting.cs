using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetermineLighting : MonoBehaviour
{
    public GameObject lighting;
    void Start()
    {
        lighting.SetActive(false);
        if (StateNameController.townProgress == 40)
        {
            lighting.SetActive(true); 
        }
    }
}
