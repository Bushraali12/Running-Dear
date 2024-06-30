using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
   public GameObject[] animalprefabs;
//    opposite to the main x- axis 
   private float spawnx= -20;
//    opposite to z- axis
   private float spawnz= 20; 
   private float timedelay=2f;
   private float repeatdelay=1.5f;
    void Start()
    {
        // invoke repeating will execute the code every single time after 2 seconds and every instantiation will occur after 1.5s
        InvokeRepeating("spawnanimalrandom",timedelay,repeatdelay);    
    }
    // Update is called once per frame
    void Update()
    {

    }
    void spawnanimalrandom()
    {
        Vector3 spawnpos= new Vector3(Random.Range(-spawnx,spawnx),0,spawnz);
            // random is class and range is its method ,they will generate any random number and place it into the animalindex variable 
            // same as Random.Range(0,3)
            int animalindex = Random.Range(0,animalprefabs.Length);
            Instantiate(animalprefabs[animalindex],spawnpos,animalprefabs[animalindex].transform.rotation);
    }
}
