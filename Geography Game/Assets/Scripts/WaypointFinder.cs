using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFinder : MonoBehaviour
{
    public string WaypointManager;
    void Start()
    {
        StateNameController.waypointManager = WaypointManager;
    }
}
