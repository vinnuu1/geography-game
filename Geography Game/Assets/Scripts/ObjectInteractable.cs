using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private Image customImage;
    public void RangerBook()
    {
        openBook();
    }
    public void Interact()
    {
        RangerBook();
    }

    public string GetInteractText()
    {
        return "Read Books";
    }
    public Transform GetTransform()
    {
        return transform;
    }
    public void openBook()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StateNameController.bookIsOpen = true;
            customImage.enabled = true;
        }
    }
    public void closeBook()
    {
        if(StateNameController.bookIsOpen == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                customImage.enabled = false;
                StateNameController.bookIsOpen = false;
            }
        }
    }
    public void Start()
    {
        customImage.enabled = false;
    }
    public void Update()
    {
        closeBook();
    }
}
