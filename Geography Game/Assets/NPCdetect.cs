using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCdetect : MonoBehaviour
{
    public GameObject interactionContainer; 

    private void Start()
    {
        interactionContainer.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            interactionContainer.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionContainer.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionContainer.SetActive(false);
        }
    }
}
