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
    }
    public void LoadNextLevel(string nextLevel)
    {
        if(nextLevel == "Town")
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

    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
