using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpdateTownProgress : MonoBehaviour
{
    public void updateTownProgress()
    {
        StateNameController.townProgress += 20;
    }
    public void updateBookshopProgress()
    {
        StateNameController.townProgress += 5;
    }
}
