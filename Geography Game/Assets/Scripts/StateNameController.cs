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
    public static int farmProgress = 0;
    public static int farmMainProgress = 0;
    public static int seeked = 0;
    public static string waypointManager; // TESTING
}
