using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteractable : MonoBehaviour, IInteractable
{
    public Animator transition;
    public float transitionTime = 1f;

    public void ToggleDoor()
    {
        LoadNextLevel();
    }

    public void Interact()
    {
        ToggleDoor();
    }

    public string GetInteractText()
    {
        return "Open Door";
    }
    public Transform GetTransform()
    {
        return transform;
    }

    public void LoadNextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
        }
        else
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
        
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
