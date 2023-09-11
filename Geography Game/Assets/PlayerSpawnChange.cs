using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(StateNameController.lastLocation == "Bookshop")
        {
            Vector3 newPosition = new Vector3(161.7f, 0f, -553.39f);
            Vector3 targetEulerAngles = new Vector3(0f, 0, 0f);
            Quaternion targetRotation = Quaternion.Euler(targetEulerAngles);

            transform.position = newPosition;
            transform.rotation = targetRotation;
        }
    }
}
