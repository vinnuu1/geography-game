using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueEditor.NPCConversation myConversation;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        ConversationManager.Instance.StartConversation(myConversation);
    }
}
