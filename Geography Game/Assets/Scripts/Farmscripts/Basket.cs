using UnityEngine;

public class Basket : MonoBehaviour
{
    // References to the invisible cabbages inside the basket.
    public GameObject[] cabbagesInBasket;

    private bool isPlayerNear = false;

    void Update()
    {
        // Check if the player is near the basket and can open it.
        if (isPlayerNear && GameManager.canOpenBasket && Input.GetKeyDown(KeyCode.E))
        {
            // Activate the invisible cabbages to make them appear.
            foreach (GameObject cabbage in cabbagesInBasket)
            {
                cabbage.SetActive(true);
            }
        }
    }

    // Detect when the player enters the trigger zone.
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
        }
    }

    // Detect when the player exits the trigger zone.
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
        }
    }
}
