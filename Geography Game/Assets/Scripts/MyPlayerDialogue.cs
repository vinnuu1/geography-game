using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class MyPlayerDialogue : MonoBehaviour
{
    public DialogueEditor.NPCConversation myConversation;
    void Start()
    {
        if(StateNameController.townProgress == 0)
        {
            GameObject dialogueObject = GameObject.FindGameObjectWithTag("PlayerDialogue1");
            myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
            ConversationManager.Instance.StartConversation(myConversation);
        }
        // Farm initial dialogue
        Debug.Log(StateNameController.townProgress);
        if (StateNameController.townProgress == 100)
        {
            GameObject dialogueObject = GameObject.FindGameObjectWithTag("PlayerDialogue2");
            myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
            ConversationManager.Instance.StartConversation(myConversation);
        }
    }
}
