using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyingobject : MonoBehaviour
{
    public float destroyThreshold = 100f; // Set your desired threshold distance

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > destroyThreshold || transform.position.z < -destroyThreshold)
        {
            Destroy(gameObject);
        }
    }
}

