using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutskirtsPlayerChange : MonoBehaviour
{
    public static string lastLocation;
    // Start is called before the first frame update
    void Start()
    {
        lastLocation = StateNameController.lastLocation;
        if (lastLocation == "RangerHouse" )
        {
            Vector3 newPosition = new Vector3(456.179993f, 5.70800018f, 418.415009f);
            Vector3 targetEulerAngles = new Vector3(0f, 180f, 0f);
            Quaternion targetRotation = Quaternion.Euler(targetEulerAngles);

            transform.position = newPosition;
            transform.rotation = targetRotation;
        }
        if (lastLocation == "Town")
        {
            Vector3 newPosition = new Vector3(498.451996f, 2.73900008f, 422.519989f);
            Vector3 targetEulerAngles = new Vector3(0f, -90f, 0f);
            Quaternion targetRotation = Quaternion.Euler(targetEulerAngles);

            transform.position = newPosition;
            transform.rotation = targetRotation;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
