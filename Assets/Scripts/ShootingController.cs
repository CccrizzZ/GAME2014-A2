using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/////////////////////////////////////////////////
// Source File Name: ShootingController.cs     //
// Student Name: Beining Liu                   //
// Student ID: 101193350                       //
// Date Last Modified: Oct 24                  //
// Program Description: shooting script.       //
/////////////////////////////////////////////////

public class ShootingController : MonoBehaviour
{

    public GameObject bullet;

    public AudioSource source;
    

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(Time.frameCount % 240 == 0)
        {
            Vector3 spawnPosition = new Vector3(0.0f, 0.5f); 
            bullet.transform.position = transform.position + spawnPosition;
            source.Play();
            Instantiate(bullet);
        }
    }
}
