using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////////////////////////////////////////////////////
// Source File Name: MenuMusic.cs                 //
// Student Name: Beining Liu                      //
// Student ID: 101193350                          //
// Date Last Modified: Oct 24                     //
// Program Description: menu music player script. //
////////////////////////////////////////////////////

public class MenuMusic : MonoBehaviour
{

    AudioSource auSource;
    // Start is called before the first frame update
    void Start()
    {

        auSource = GetComponent<AudioSource>();
        if (!auSource.isPlaying)
        {
            auSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
