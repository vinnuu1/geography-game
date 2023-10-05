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
        if (StateNameController.enableWaypoint == true)
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
        else
        {
            img.enabled = false;
            meter.enabled = false;
        }
    }
    private void determineWaypoint()
    {
        if (StateNameController.waypointManager == "Outskirts")
        {
            GameObject outskirtstotown = GameObject.FindGameObjectWithTag("Town");
            target = outskirtstotown.transform;
        }

        // Police Woman waypoint
        if (StateNameController.townProgress == 0 && StateNameController.waypointManager == "Town")
        {
            GameObject policewoman = GameObject.FindGameObjectWithTag("PoliceWoman");
            target = policewoman.transform;
        }

        // Bookshop waypoint
        if (StateNameController.townProgress == 20 && StateNameController.waypointManager == "Town")
        {
            GameObject bookshop = GameObject.FindGameObjectWithTag("BookShop");
            target = bookshop.transform;
        }

        // Bookshop keeper waypoint
        if (StateNameController.townProgress == 20 && StateNameController.waypointManager == "Bookshop")
        {
            GameObject keeper = GameObject.FindGameObjectWithTag("Keeper");
            target = keeper.transform;
        }
        // Bookshop CUSTOMER1 waypoint
        if (StateNameController.townProgress == 25 && StateNameController.waypointManager == "Bookshop")
        {
            GameObject customer = GameObject.FindGameObjectWithTag("FemaleCustomer");
            target = customer.transform;
        }
        // Bookshop CUSTOMER2 waypoint
        if (StateNameController.townProgress == 30 && StateNameController.waypointManager == "Bookshop")
        {
            GameObject customer = GameObject.FindGameObjectWithTag("MaleCustomer");
            target = customer.transform;
        }
        // Bookshop keeper2 waypoint
        if (StateNameController.townProgress == 35 && StateNameController.waypointManager == "Bookshop")
        {
            GameObject keeper = GameObject.FindGameObjectWithTag("Keeper");
            target = keeper.transform;
        }
        // Leave Bookshop waypoint
        if (StateNameController.townProgress == 40 && StateNameController.waypointManager == "Bookshop")
        {
            GameObject finish = GameObject.FindGameObjectWithTag("Finish");
            target = finish.transform;
        }

        // Town - Talk to teacher waypoint
        if (StateNameController.townProgress == 40 && StateNameController.waypointManager == "Town")
        {
            GameObject maleteacher = GameObject.FindGameObjectWithTag("MaleTeacher");
            target = maleteacher.transform;
        }
        // Town - Talk to kid1 waypoint
        if (StateNameController.townProgress == 45 && StateNameController.waypointManager == "Town")
        {
            GameObject kid = GameObject.FindGameObjectWithTag("kid1");
            target = kid.transform;
        }
        // Town - Talk to kid2 waypoint
        if (StateNameController.townProgress == 50 && StateNameController.waypointManager == "Town")
        {
            GameObject kid = GameObject.FindGameObjectWithTag("kid2");
            target = kid.transform;
        }
        // Town - Talk to kid2 waypoint
        if (StateNameController.townProgress == 55 && StateNameController.waypointManager == "Town")
        {
            GameObject kid = GameObject.FindGameObjectWithTag("kid3");
            target = kid.transform;
        }
        // Town - Final conversation with teacher
        if (StateNameController.townProgress == 80 && StateNameController.waypointManager == "Town")
        {
            GameObject maleteacher = GameObject.FindGameObjectWithTag("MaleTeacher");
            target = maleteacher.transform;
        }
        if (StateNameController.townProgress == 100 && StateNameController.waypointManager == "Town")
        {
            GameObject farmLevel = GameObject.FindGameObjectWithTag("Farm");
            target = farmLevel.transform;
        }
    }
}
