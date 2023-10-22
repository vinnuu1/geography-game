using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class FinalLevel : MonoBehaviour
{
    public DialogueEditor.NPCConversation myConversation;
    public void updateWrongCount()
    {
        StateNameController.wrong += 1;
        ConversationManager.Instance.SetInt("wrong", StateNameController.wrong);
    }
    public void resetWrongCount()
    {
        StateNameController.wrong = 0;
        ConversationManager.Instance.SetInt("wrong", StateNameController.wrong);
    }
    public void resetAllVars()
    {
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
    }
}
