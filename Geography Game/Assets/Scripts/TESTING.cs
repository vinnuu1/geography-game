using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTING : MonoBehaviour
{
    public int townProgress;
    public string lastLocation;
    public bool wayPoint;
    // Start is called before the first frame update
    void Start()
    {
        StateNameController.townProgress = townProgress;
        StateNameController.enableWaypoint = wayPoint;
        StateNameController.lastLocation = lastLocation;
    }
}
