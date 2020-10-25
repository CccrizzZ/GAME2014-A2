using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;



///////////////////////////////////////////////////////////
// Source File Name: QuitGameButtonBehavior.cs           //
// Student Name: Beining Liu                             //
// Student ID: 101193350                                 //
// Date Last Modified: Oct 24                            //
// Program Description: quit game button behavior script.//
///////////////////////////////////////////////////////////





public class QuitGameButtonBehavior : MonoBehaviour
{

    public AudioSource source;
    

    void Start()
    {
        source = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnQuitGameButtonPressed()
    {
        StartCoroutine("QuitGameRoutine");   
        
    }


    IEnumerator QuitGameRoutine()
    {
        source.Play();
        yield return new WaitForSeconds(source.clip.length);
        Debug.Log("QuitGame Pressed");
        Application.Quit();
        
        
        
    }
}
