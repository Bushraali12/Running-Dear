using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;  // Adjusted to be negative for left limit
    private float rightLimit = 30;  // Added a right limit
    private float bottomLimit = -2;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position is outside the left or right limit
        if (transform.position.x < leftLimit || transform.position.x > rightLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.z < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}

