using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    public float speed = 1.0f; // Adjust the speed to control the movement

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the platform
        Vector3 pos = transform.position;

        // Move the platform to the left along the x-axis with a smooth speed
        pos.x -= speed * Time.deltaTime;

        // Apply the translation to the platform's position
        transform.position = pos;
    }
}

