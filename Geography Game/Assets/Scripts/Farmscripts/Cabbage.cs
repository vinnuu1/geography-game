using UnityEngine;

public class Cabbage : MonoBehaviour
{
    
    public GameObject basket;

    private bool isPlayerNear = false;
    private bool isInsideBasket = false; 



    void Update()
    {
      
        if (!isInsideBasket && isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
        
            GameManager.cabbageCount++;

            
            if (GameManager.cabbageCount >= 9)
            {
                StateNameController.farmProgress = 100;
                GameManager.canOpenBasket = true;
            }

            
            gameObject.SetActive(false);

            
            isInsideBasket = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
        }
    }
}
