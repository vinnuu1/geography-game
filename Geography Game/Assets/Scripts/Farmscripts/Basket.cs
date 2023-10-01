using UnityEngine;

public class Basket : MonoBehaviour
{
    private bool isPlayerNear = false;
    public GameObject crop1;
    public GameObject crop2;
    public GameObject crop3;
    public GameObject crop4;
    public GameObject crop5;
    public GameObject crop6;
    public GameObject crop7;
    void Update()
    {
        
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E) && GameManager.cabbageCount >= 9)
        {
            Debug.Log("OpenBasket");
            OpenBasket();
        }
    }

    
    void OpenBasket()
    {
        Debug.Log("Cropactive");
        crop1.SetActive(true);
        crop2.SetActive(true);
        crop3.SetActive(true);
        crop4.SetActive(true);
        crop5.SetActive(true);
        crop6.SetActive(true);
        crop7.SetActive(true);
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
