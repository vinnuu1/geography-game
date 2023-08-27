using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPCInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;
    public string lastLocation;

    public DialogueEditor.NPCConversation myConversation;
    public void Interact()
    {
        ConversationManager.Instance.StartConversation(myConversation);
    }

    public string GetInteractText()
    {
        return interactText;
    }
    public Transform GetTransform() {
        return transform;
    }
    void Start()
    {
        lastLocation = StateNameController.lastLocation;

        if (lastLocation == "RangerHouse")
        {
            // Change Ranger dialogue
            GameObject dialogueObject = GameObject.FindGameObjectWithTag("RangerDialogue2");

            myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
            Debug.Log("UpdateWorks");
        }
    }
    void Update()
    {
        // Ranger Dialogue Update
        GameObject rangerObject = GameObject.FindGameObjectWithTag("Ranger");
        GameObject dialogueObject = GameObject.FindGameObjectWithTag("Dialogue");

        if(rangerObject != null)
        {
            if (ConversationManager.Instance.IsConversationActive)
            {
                myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                Debug.Log("UpdateWorks");
            }
        }
    }
}
