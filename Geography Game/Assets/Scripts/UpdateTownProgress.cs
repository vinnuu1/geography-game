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
    public void updateProgress10()
    {
        StateNameController.townProgress += 10;
    }

    public void updateFarmProgress()
    {
        StateNameController.farmProgress = 20;
    }
    public void updateMainFarmProgress()
    {
        StateNameController.farmMainProgress += 20;
    }
    public void updateMainFarmProgress10()
    {
        StateNameController.farmMainProgress += 10;
    }
    public void updateMainFarmProgress5()
    {
        StateNameController.farmMainProgress += 5;
    }
    public void finishForest()
    {
        StateNameController.forestProgress = 100;
    }
}
