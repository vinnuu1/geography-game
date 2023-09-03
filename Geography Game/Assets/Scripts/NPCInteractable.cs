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
            Debug.Log("works2");
            // If Town has been visited change to ranger dialogue 3
            if(StateNameController.visitedTown == true)
            {
                RangerDialogueAfterTown();
            }
            // If town has not been visited change to ranger dialogue 2
            else
            {
                // Check if quiz has already been done
                if(StateNameController.enableWaypoint == true)
                {
                    Debug.Log("works3");
                    GameObject rangerObject = GameObject.FindGameObjectWithTag("Ranger");
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("Dialogue");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
                else
                {
                    // Change Ranger dialogue to quiz
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("RangerDialogue2");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
            }
        }
        // If Town has been visited change to ranger dialogue 3
        if (lastLocation == "Town")
        {
            RangerDialogueAfterTown();
            StateNameController.visitedTown = true;
        }
    }
    void Update()
    {
        // Ranger Dialogue Update
        GameObject rangerObject = GameObject.FindGameObjectWithTag("Ranger");
        GameObject dialogueObject = GameObject.FindGameObjectWithTag("Dialogue");

        if (rangerObject != null)
        {
            if (ConversationManager.Instance.IsConversationActive)
            {
                myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
            }
        }
    }
    void RangerDialogueAfterTown()
    {
        // Change Ranger dialogue
        GameObject dialogueObject = GameObject.FindGameObjectWithTag("RangerDialogue3");

        myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
    }
}
