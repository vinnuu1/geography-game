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
                StateNameController.finishedReading = false;
                StateNameController.visitedTown = false;
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