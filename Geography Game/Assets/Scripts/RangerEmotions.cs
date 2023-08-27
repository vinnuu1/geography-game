using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class RangerEmotions : MonoBehaviour
{
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Talk()
    {
        animator.SetTrigger("Talk");
    }
    public void Surprised()
    {
        animator.SetTrigger("Surprised");
    }
    public void Idea()
    {
        animator.SetTrigger("Idea");
    }
    public void Laugh()
    {
        animator.SetTrigger("Laugh");
    }
    public void Rejected()
    {
        animator.SetTrigger("Rejected");
    }
}
