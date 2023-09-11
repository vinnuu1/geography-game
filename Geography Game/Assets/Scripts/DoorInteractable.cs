using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteractable : MonoBehaviour, IInteractable
{
    public Animator transition;
    public float transitionTime = 1f;
    public double levelNumber;

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
        if(levelNumber == 2) { }
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
        //
        if (levelNumber == 3)
        {
            Debug.Log("help");
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
        }
        //Bookshop
        if(levelNumber == 5)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
        //Bookshop to Town
        if(levelNumber == 4.1)
        {
            StateNameController.lastLocation = "Bookshop";
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
        }
        
        
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
