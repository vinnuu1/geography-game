using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public NPC npc;

    bool isTalking = false;

    float distance;
    int curResponseTracker = 0;

    public GameObject player;
    public GameObject dialogueUI;

    public TextMeshProUGUI npcName;
    public TextMeshProUGUI npcDialogueBox;
    public TextMeshProUGUI playerResponse;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    void Update()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);
        if (distance <= 2.5f)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                curResponseTracker++;
                if (curResponseTracker >= npc.playerDialogue.Length)
                {
                    curResponseTracker = npc.playerDialogue.Length - 1;
                }
            }
            else if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                curResponseTracker--;
                if (curResponseTracker < 0)
                {
                    curResponseTracker = 0;
                }
            }

            if (Input.GetKeyDown(KeyCode.E) && !isTalking)
            {
                StartConversation();
            }
            else if (Input.GetKeyDown(KeyCode.E) && isTalking)
            {
                EndDialogue();
            }

            if (curResponseTracker >= 0 && curResponseTracker < npc.playerDialogue.Length)
            {
                playerResponse.text = npc.playerDialogue[curResponseTracker];

                int npcDialogueIndex = curResponseTracker + 1; // Assuming NPC dialogue starts from index 1
                if (npcDialogueIndex < npc.dialogue.Length)
                {
                    if (Input.GetMouseButton(0))
                    {
                        npcDialogueBox.text = npc.dialogue[npcDialogueIndex];
                    }
                }
            }
        }
    }

    void StartConversation()
    {
        isTalking = true;
        curResponseTracker = 0;
        dialogueUI.SetActive(true);
        npcName.text = npc.name;
        npcDialogueBox.text = npc.dialogue[0];
    }

    void EndDialogue()
    {
        isTalking = false;
        dialogueUI.SetActive(false);
    }
}
