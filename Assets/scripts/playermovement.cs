using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float horizontalinput;
    public float speed=10.0f;
    public float xrange=10;
    public GameObject prefabprojector;
    // Update is called once per frame
    void Update()
    {
        if ( transform.position.x < -xrange)
        {
            transform.position=new Vector3(-xrange,transform.position.y,transform.position.z);
        }
        if ( transform.position.x > xrange)
        {
            transform.position=new Vector3(xrange,transform.position.y,transform.position.z);
        }
        horizontalinput=Input.GetAxis("Horizontal");
        // keep x coordinate to -10 and y,z in same position
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed );
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabprojector,transform.position,prefabprojector.transform.rotation);
        }
    }
}
