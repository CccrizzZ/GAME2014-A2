using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

using UnityEngine.SceneManagement;


//////////////////////////////////////////////////////////
// Source File Name: NewGameButtonBehavior.cs           //
// Student Name: Beining Liu                            //
// Student ID: 101193350                                //
// Date Last Modified: Oct 24                           //
// Program Description: new game button behavior script.//
//////////////////////////////////////////////////////////

public class NewGameButtonBehavior : MonoBehaviour
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

    public void OnNewGameButtonPressed()
    {
        StartCoroutine("StartGameRoutine");   
    }
    
    IEnumerator StartGameRoutine()
    {
        source.Play();
        yield return new WaitForSeconds(source.clip.length);
        Debug.Log("NewGame Pressed");
        SceneManager.LoadScene("GPS");
        
    }

}
