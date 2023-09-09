using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateNameController : MonoBehaviour
{
    public static string lastLocation;
    public static bool bookIsOpen;
    public static bool enableWaypoint;
    public static bool visitedTown = false;
    public static int townProgress = 0;
    public static string waypointManager = "Town"; // TESTING
}
