using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPCInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;
    public string lastLocation;
    public int townProgress;
    

    public DialogueEditor.NPCConversation myConversation;
    public void Interact()
    {
        checkDialogue();
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
                    StateNameController.waypointManager = "Outskirts";
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

        // Bookshop Testing

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
    void checkDialogue()
    {
        if (StateNameController.waypointManager == "Town")
        {
            if(gameObject.tag == "PoliceWoman")
            {
                if (StateNameController.townProgress == 0)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("PoliceWomanDialogue1");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
            }
        }
        if (StateNameController.waypointManager == "Bookshop")
        {
            if(gameObject.tag == "Keeper")
            {
                if (StateNameController.townProgress == 20)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("KeeperDialogue1");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
                if (25 <= StateNameController.townProgress && StateNameController.townProgress < 35)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("KeeperDialogue1.5");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
                if (StateNameController.townProgress == 35)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("KeeperDialogue2");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
            }
        }
        if(StateNameController.waypointManager == "Town")
        {
            // School Storyline Start
            if (gameObject.tag == "MaleTeacher")
            {
                Debug.Log("checkech");
                Debug.Log(StateNameController.townProgress);
                if (StateNameController.townProgress == 40)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("MTeacher1");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
                if (StateNameController.townProgress == 90)
                {
                    Debug.Log("checkech2");
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("MTeacher2");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
            }
        }


        if (StateNameController.waypointManager == "Farm")
        {
            if (gameObject.tag == "FarmerWomen")
            {
                if (StateNameController.farmProgress == 100)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("FarmerTalk2");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }

                if (StateNameController.farmProgress == 20)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("FarmerTalk3");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
            }
            if (gameObject.tag == "FarmerMan")
            {
                if (StateNameController.farmMainProgress == 0)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("FarmerManTalk1");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
                if (StateNameController.farmMainProgress == 20)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("FarmerManTalk2");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
                if (StateNameController.farmMainProgress == 60)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("FarmerManTalk3");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
            }
            if (gameObject.tag == "Aaron")
            {
                if (StateNameController.farmMainProgress == 70)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("AaronTalk1");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
                if (StateNameController.farmMainProgress > 70 && StateNameController.farmMainProgress < 105)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("AaronTalk2");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
                if (StateNameController.farmMainProgress == 110)
                {
                    GameObject dialogueObject = GameObject.FindGameObjectWithTag("AaronTalk3");
                    myConversation = dialogueObject.GetComponent<DialogueEditor.NPCConversation>();
                }
            }
        }


    }
}
