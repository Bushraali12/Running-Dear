using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectingobject : MonoBehaviour
{
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal"))
       {
        Destroy(gameObject);
        Destroy(other.gameObject);
       }
    }
}
