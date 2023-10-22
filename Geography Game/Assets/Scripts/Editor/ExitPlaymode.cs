using System.Collections;
using System.Collections.Generic;
using UnityEditor;


[InitializeOnLoad]
public class DetectPlayModeChanges
{

    static DetectPlayModeChanges()
    {
        EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
    }

    private static void OnPlayModeStateChanged(PlayModeStateChange state)
    {
        switch (state)
        {
            case PlayModeStateChange.ExitingEditMode:
                StateNameController.lastLocation = "";
                StateNameController.bookIsOpen = false;
                StateNameController.enableWaypoint = false;
                StateNameController.visitedTown = false;
                StateNameController.townProgress = 0;
                StateNameController.farmProgress = 0;
                StateNameController.farmMainProgress = 0;
                StateNameController.forestProgress = 0;
                StateNameController.seeked = 0;
                StateNameController.wrong = 0;
                StateNameController.waypointManager = "";
                // Do whatever before entering play mode
                break;
            case PlayModeStateChange.EnteredPlayMode:
                // Do whatever after entering play mode
                break;
            case PlayModeStateChange.ExitingPlayMode:
                // Do whatever before returning to edit mode
                break;
            case PlayModeStateChange.EnteredEditMode:
                // Do whatever after returning to edit mode
                break;
        }
    }
}