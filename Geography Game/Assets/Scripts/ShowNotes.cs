using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNotes : MonoBehaviour
{
    [SerializeField] private Image customImage;
    [SerializeField] private Canvas customCanvas;
    public void showNotes()
    {
        StateNameController.bookIsOpen = true;
        customImage.enabled = true;
        customCanvas.enabled = true;
    }
    public void closeNotes()
    {
        if (StateNameController.bookIsOpen == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                customImage.enabled = false;
                customCanvas.enabled = false;
                StateNameController.bookIsOpen = false;
            }
        }
    }
    public void Start()
    {
        customImage.enabled = false;
        customCanvas.enabled = false;
    }
    public void Update()
    {
        closeNotes();
    }
}
