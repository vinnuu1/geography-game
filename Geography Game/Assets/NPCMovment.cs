using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovment : MonoBehaviour
{
    public float speed = 2.0f;
    public float walkDuration = 10.0f; // Duration to walk forward and back
    private float timer = 0.0f;
    private bool isWalkingForward = true;

    private void Update()
    {
        timer += Time.deltaTime;

        // Check if the NPC should walk forward or backward based on the timer
        if (isWalkingForward)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        // Check if the duration has passed, and switch walking direction
        if (timer >= walkDuration)
        {
            isWalkingForward = !isWalkingForward;
            timer = 0.0f;
        }
    }
}
