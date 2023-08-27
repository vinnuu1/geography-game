using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPCInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public DialogueEditor.NPCConversation myConversation;
    public void Interact()
    {
        Debug.Log("2");
        ConversationManager.Instance.StartConversation(myConversation);
        animator.SetTrigger("Talk");
    }

    public string GetInteractText()
    {
        return interactText;
    }
    public Transform GetTransform() {
        return transform;
    }
}
