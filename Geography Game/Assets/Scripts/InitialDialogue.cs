using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class InitialDialogue : MonoBehaviour
{
    public DialogueEditor.NPCConversation myConversation;
    // Start is called before the first frame update
    void Start()
    {
        if(StateNameController.forestProgress == 0)
        {
            GameObject dialogueObject = GameObject.FindGameObjectWithTag("PlayerDialogue2");
            myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
            ConversationManager.Instance.StartConversation(myConversation);
        }   
    }
}
