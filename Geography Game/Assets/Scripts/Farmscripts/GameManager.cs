using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int cabbageCount = 0;
    public static bool canOpenBasket = false;
    void Start()
    {
        cabbageCount = 0;
    }
    void Update()
    {
        // This will log the initial cabbage count when the game starts.
        Debug.Log(" Cabbage Count: " + cabbageCount);
        if (cabbageCount >= 9)
        {
            canOpenBasket = true;
        }
    }
}
