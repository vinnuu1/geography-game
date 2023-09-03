using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableWaypointOnDialogue : MonoBehaviour
{
    public void enableWaypoint()
    {
        StateNameController.enableWaypoint = true;
    }
}
