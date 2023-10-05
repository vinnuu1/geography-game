using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class HideandSeekQuest : MonoBehaviour
{
    public DialogueEditor.NPCConversation myConversation;
    public void updateSeekCount()
    {
        StateNameController.seeked += 1;
        ConversationManager.Instance.SetInt("seeked", StateNameController.seeked);
    }
}
