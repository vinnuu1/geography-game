using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waypoint : MonoBehaviour
{
    public Image img;
    public Transform target;
    public Text meter;
    public Vector3 offset;

    public void Start()
    {
        img.enabled = false;
        meter.enabled = false;
    }
    private void Update()
    {
        determineWaypoint();
        showWaypoint();
    }
    private void showWaypoint()
    {
        if(StateNameController.enableWaypoint == true)
        {
            img.enabled = true;
            meter.enabled = true;
            float minX = img.GetPixelAdjustedRect().width / 2;
            float maxX = Screen.width - minX;

            float minY = img.GetPixelAdjustedRect().height / 2;
            float maxY = Screen.height - minY;

            Vector2 pos = Camera.main.WorldToScreenPoint(target.position + offset);

            if (Vector3.Dot((target.position - transform.position), transform.forward) < 0)
            {
                if (pos.x < Screen.width / 2)
                {
                    pos.x = maxX;
                }
                else
                {
                    pos.x = minX;
                }
            }

            pos.x = Mathf.Clamp(pos.x, minX, maxX);
            pos.y = Mathf.Clamp(pos.y, minY, maxY);

            img.transform.position = pos;
            meter.text = ((int)Vector3.Distance(target.position, transform.position)).ToString() + "m";
        }
    }
    private void determineWaypoint()
    {
        if (StateNameController.waypointManager == "Outskirts")
        {
            GameObject outskirtstotown = GameObject.FindGameObjectWithTag("Town");
            target = outskirtstotown.transform;
        }

        if (StateNameController.townProgress == 0 && StateNameController.waypointManager == "Town")
        {
            GameObject policewoman = GameObject.FindGameObjectWithTag("PoliceWoman");
            target = policewoman.transform;
        }
    }
}
