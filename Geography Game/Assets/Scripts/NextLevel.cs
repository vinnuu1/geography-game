using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public GameObject targetObject;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (targetObject.CompareTag("Town"))
        {
            Debug.Log("WorksTown");
            LoadNextLevel("Town");
        }
        if(targetObject.CompareTag("Outskirts"))
        {
            LoadNextLevel("Outskirts");
        }
        if (targetObject.CompareTag("Farm"))
        {
            LoadNextLevel("Farm");
        }
        if (targetObject.CompareTag("Forest"))
        {
            LoadNextLevel("Forest");
        }
    }
    public void FarmCutscene()
    {
        LoadNextLevel("FarmCutscene");
    }
    public void IntroScene()
    {
        LoadNextLevel("Intro");
    }
    public void failedLevel()
    {
        LoadNextLevel("Failed");
    }
    public void Menu()
    {
        LoadNextLevel("Menu");
    }
    public void LoadNextLevel(string nextLevel)
    {
        if (nextLevel == "Intro")
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
            }
            if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
            }
            if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
            }
            if (SceneManager.GetActiveScene().buildIndex == 11)
            {
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
            }
        }
        if (nextLevel == "Town")
        {
            // Outskirts to Town
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
                StateNameController.lastLocation = "Outskirts";
                StateNameController.enableWaypoint = false;
                StateNameController.waypointManager = "Town";
            }
        }
        if(nextLevel == "Outskirts")
        {
            // Town to Outskirts
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 2));
                StateNameController.lastLocation = "Town";
            }
        }
        if (nextLevel == "Farm")
        {
            // Town to Farm
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
                StateNameController.lastLocation = "Town";
            }
        }
        if (nextLevel == "FarmCutscene")
        {
            if (SceneManager.GetActiveScene().buildIndex == 6 || SceneManager.GetActiveScene().buildIndex == 7)
            {
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
            }
        }
        if (nextLevel == "Forest")
        {
            if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
            }
        }
        if (nextLevel == "Failed")
        {
            if (SceneManager.GetActiveScene().buildIndex == 11)
            {
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
            }
        }
        if (nextLevel == "Menu")
        {
            if (SceneManager.GetActiveScene().buildIndex == 12)
            {
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 12));
            }
        }
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
