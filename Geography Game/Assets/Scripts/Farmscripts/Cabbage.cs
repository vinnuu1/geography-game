using UnityEngine;

public class Cabbage : MonoBehaviour
{
    // Reference to the basket GameObject.
    public GameObject basket;

    private bool isPlayerNear = false;
    private bool isInsideBasket = false; // Flag to track if the cabbage is inside the basket.



    void Update()
    {
        // Check if the player presses the "E" key and is near the cabbage crop.
        if (!isInsideBasket && isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            // Increment the cabbage count through the GameManager script.
            GameManager.cabbageCount++;

            // Check if the player has picked 10 cabbages.
            if (GameManager.cabbageCount >= 3)
            {
                GameManager.canOpenBasket = true;
            }

            // Disable the cabbage crop GameObject.
            gameObject.SetActive(false);

            // Set the flag to indicate that the cabbage is inside the basket.
            isInsideBasket = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the player enters the trigger zone.
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the player exits the trigger zone.
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
        }
    }
}
